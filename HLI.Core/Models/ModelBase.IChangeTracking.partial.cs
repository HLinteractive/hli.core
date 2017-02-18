// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.ModelBase.IChangeTracking.partial.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Runtime.Serialization;

using HLI.Core.Interfaces.Models;

namespace HLI.Core.Models
{
    /// <summary>
    ///     Implementation of <seealso cref="IChangeTracking" /> for ModelBase.
    /// </summary>
    public abstract partial class ModelBase : AuditedObject, IModelBase
    {
        #region Fields

        private bool? isChanged;

        #endregion

        #region Constructors and Destructors

        protected ModelBase()
        {
            this.Id = Guid.NewGuid();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     <seealso cref="IChangeTracking.IsChanged" />
        /// </summary>
        [DataMember]
        public bool IsChanged
        {
            get
            {
                if (!this.isChanged.HasValue)
                {
                    this.PropertyChanged -= this.MarkAsChanged;
                    this.PropertyChanged += this.MarkAsChanged;
                    return false;
                }

                return this.isChanged.Value;
            }

            set
            {
                if (!this.isChanged.HasValue)
                {
                    this.PropertyChanged -= this.MarkAsChanged;
                    this.PropertyChanged += this.MarkAsChanged;
                }

                if (this.isChanged != value)
                {
                    this.isChanged = value;
                    this.RaisePropertyChanged(() => this.IsChanged);
                }
            }
        }

        #endregion

        #region Public Methods and Operators

        public void AcceptChanges()
        {
            this.IsChanged = false;
        }

        #endregion

        #region Methods

        private void MarkAsChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName != "IsChanged")
            {
                this.IsChanged = true;
            }
        }

        #endregion
    }
}