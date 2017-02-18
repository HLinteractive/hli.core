// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IObjectWithGuidAudit.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes an object with audit tracking
    /// </summary>
    public interface IObjectWithGuidAudit : IObjectWithGuidId
    {
        #region Public Properties

        DateTime Created { get; set; }

        DateTime Updated { get; set; }

        Guid UserCreatedBy { get; set; }

        Guid UserUpdatedBy { get; set; }

        #endregion
    }
}