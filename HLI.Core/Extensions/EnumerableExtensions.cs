// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.EnumerableExtensions.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System.Collections;

namespace HLI.Core.Extensions
{
    public static class EnumerableExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Returns the index of the specified object in the collection.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="obj">The object.</param>
        /// <returns>If found returns index otherwise -1</returns>
        public static int IndexOf(this IEnumerable self, object obj)
        {
            var index = -1;

            var enumerator = self.GetEnumerator();
            enumerator.Reset();
            var i = 0;
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == obj)
                {
                    index = i;
                    break;
                }

                i++;
            }

            return index;
        }

        #endregion
    }
}