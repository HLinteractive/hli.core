// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Models.IFilterableModel.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes a model that can be filtered
    /// </summary>
    public interface IFilterableObject
    {
        #region Public Properties

        /// <summary>
        ///     The property used to filter this model
        /// </summary>
        string FilterProperty { get; }

        #endregion
    }
}