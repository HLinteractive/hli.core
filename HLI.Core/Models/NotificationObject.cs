// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.NotificationObject.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

using HLI.Core.Extensions;

namespace HLI.Core.Models
{
    /// <summary>
    ///     Implements the <see cref="INotifyPropertyChanged" />
    /// </summary>
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        protected void RaisePropertyChanged<TProperty>(Expression<Func<TProperty>> property)
        {
            var propertyName = property.ToPropertyName();
            this.RaisePropertyChanged(propertyName);
        }

        /// <summary>
        ///     Updates the property as needed
        /// </summary>
        /// <typeparam name="TProp">Type of property</typeparam>
        /// <param name="storage">Backing field</param>
        /// <param name="value">New value</param>
        /// <param name="propertyName">Public property</param>
        /// <returns>True if changed</returns>
        protected bool SetProperty<TProp>(ref TProp storage, TProp value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            this.RaisePropertyChanged(propertyName);
            return true;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}