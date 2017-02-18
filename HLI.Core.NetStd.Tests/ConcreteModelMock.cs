// // // --------------------------------------------------------------------------------------------------------------------
// // // <copyright file="HLI.Core.NetStd.Tests.ConcreteModelMock.cs" company="Sogeti Sverige AB">
// // //   Copyright © Sogeti Sverige AB, 2016
// // // </copyright>
// // // --------------------------------------------------------------------------------------------------------------------

using HLI.Core.Models;

namespace HLI.Core.NetStd.Tests
{
    /// <summary>
    ///     A concrete implementation of <see cref="HLI.Core.Models.ModelBase" /> used for mocking in tests.
    /// </summary>
    public class ConcreteModelMock : ModelBase
    {
        #region Fields

        private string stringProperty;

        #endregion

        #region Public Properties

        /// <summary>
        ///     Test string property
        /// </summary>
        public string StringProperty
        {
            get
            {
                return this.stringProperty;
            }

            set
            {
                this.SetProperty(ref this.stringProperty, value);
            }
        }

        #endregion
    }
}