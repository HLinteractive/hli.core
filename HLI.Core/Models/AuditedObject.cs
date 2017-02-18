// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.AuditedObject.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

using HLI.Core.Interfaces.Models;

namespace HLI.Core.Models
{
    /// <summary>
    ///     Base implementation of <see cref="IObjectWithGuidAudit" />. Inherits <see cref="EditableObject" />
    /// </summary>
    public abstract class AuditedObject : EditableObject, IObjectWithAudit

    {
        #region Fields

        private DateTime created;

        private Guid id;

        private DateTime updated;

        private int userCreatedBy;

        private int userUpdatedBy;

        private int version;

        #endregion

        #region Public Properties

        [DataMember]
        public DateTime Created
        {
            get
            {
                return this.created;
            }

            set
            {
                this.SetProperty(ref this.created, value);
            }
        }

        [DataMember]
        public Guid Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.SetProperty(ref this.id, value);
            }
        }

        public bool IsPersisted => this.version != 0;

        [DataMember]
        public DateTime Updated
        {
            get
            {
                return this.updated;
            }

            set
            {
                this.SetProperty(ref this.updated, value);
            }
        }

        [DataMember]
        public int UserCreatedBy
        {
            get
            {
                return this.userCreatedBy;
            }

            set
            {
                this.SetProperty(ref this.userCreatedBy, value);
            }
        }

        [DataMember]
        public int UserUpdatedBy
        {
            get
            {
                return this.userUpdatedBy;
            }

            set
            {
                this.SetProperty(ref this.userUpdatedBy, value);
            }
        }

        [DataMember]
        public int Version
        {
            get
            {
                return this.version;
            }

            set
            {
                this.SetProperty(ref this.version, value);
            }
        }

        #endregion
    }
}