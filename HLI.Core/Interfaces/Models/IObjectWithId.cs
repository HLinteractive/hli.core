// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IObjectWithId.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes an object with Id
    /// </summary>
    public interface IObjectWithId
    {
        #region Public Properties

        /// <summary>
        ///     Id for the entity. Is normally generated in <see cref="IModelBase" />
        /// </summary>
        int Id { get; set; }

        #endregion
    }
}