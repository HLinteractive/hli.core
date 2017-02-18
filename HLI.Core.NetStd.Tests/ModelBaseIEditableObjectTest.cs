// // // --------------------------------------------------------------------------------------------------------------------
// // // <copyright file="HLI.Core.Tests.ModelBaseIEditableObjectTest.cs" company="Sogeti Sverige AB">
// // //   Copyright © Sogeti Sverige AB, 2016
// // // </copyright>
// // // --------------------------------------------------------------------------------------------------------------------

using NUnit.Framework;

// ReSharper disable InconsistentNaming - TESTS

namespace HLI.Core.NetStd.Tests
{
    [TestFixture]
    public class ModelBaseIEditableObjectTest
    {
        #region Public Methods and Operators

        [Test]
        public void EditProperty_IsChangedReturnsTrue()
        {
            // Arrange
            var model = new ConcreteModelMock();
            model.BeginEdit();

            // Act
            model.StringProperty = "new value";

            // Assert
            Assert.IsTrue(model.IsChanged);
        }

        [Test]
        public void NewModel_NoChanges_IsChangedReturnsFalse()
        {
            // Act
            var model = new ConcreteModelMock();

            // Assert
            Assert.IsFalse(model.IsChanged);
        }

        #endregion
    }
}