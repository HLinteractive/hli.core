// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IValidationActive.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Describes a class that can be validated
    /// </summary>
    public interface IValidationActive
    {
        #region Public Methods and Operators

        void Validate(string propertyname);

        #endregion
    }
}