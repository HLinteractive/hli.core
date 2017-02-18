// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IObjectWithGuidId.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes an object with Id
    /// </summary>
    public interface IObjectWithGuidId
    {
        #region Public Properties

        /// <summary>
        ///     Id for the entity. Is normally generated in <see cref="IModelBase" />
        /// </summary>
        Guid Id { get; set; }

        #endregion
    }
}