// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.ModelBase.FilterableObject.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using HLI.Core.Interfaces.Models;

namespace HLI.Core.Models
{
    public partial class ModelBase : IFilterableObject
    {
        #region Public Properties

        /// <summary>
        ///     Default implementation of <see cref="IFilterableObject.FilterProperty" /> that returns this.ToString();
        /// </summary>
        public virtual string FilterProperty => this.ToString();

        #endregion
    }
}