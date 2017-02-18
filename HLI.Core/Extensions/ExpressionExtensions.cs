// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.ExpressionExtensions.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System.Linq.Expressions;

namespace HLI.Core.Extensions
{
    /// <summary>
    ///     Custom HLi extensions to <see cref="Expression" />
    /// </summary>
    public static class ExpressionExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Returns the property name of said <see cref="Expression" />
        /// </summary>
        /// <param name="property">this</param>
        /// <returns>Property name as string</returns>
        public static string ToPropertyName(this Expression property)
        {
            var lambda = (LambdaExpression)property;
            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)lambda.Body;
            }

            return memberExpression.Member.Name;
        }

        #endregion
    }
}