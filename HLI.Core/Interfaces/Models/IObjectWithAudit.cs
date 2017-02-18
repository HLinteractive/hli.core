// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IObjectWithAudit.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes an object with audit tracking
    /// </summary>
    public interface IObjectWithAudit : IObjectWithGuidId
    {
        #region Public Properties

        DateTime Created { get; set; }

        /// <summary>
        ///     Gets a value indicating if this object has been persisted to database.
        /// </summary>
        /// <seealso cref="Version" />
        bool IsPersisted { get; }

        DateTime Updated { get; set; }

        int UserCreatedBy { get; set; }

        int UserUpdatedBy { get; set; }

        /// <summary>
        ///     Determines how many times this item has been persisted to the database. Default is 0.
        /// </summary>
        int Version { get; set; }

        #endregion
    }
}