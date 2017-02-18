// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.DateTimeSpan.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;

namespace HLI.Core
{
    /// <summary>
    ///     Represents a date &amp; time span (<see cref="Start" /> to <see cref="End" />
    /// </summary>
    public class DateTimeSpan
    {
        #region Constructors and Destructors

        public DateTimeSpan(DateTime start, DateTime end)
        {
            ////if (end < start)
            ////{
            ////    throw new ArgumentOutOfRangeException("end", @"End cannot be before start");
            ////}

            this.Start = start;
            this.End = end;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Returns the duration of this span
        /// </summary>
        public TimeSpan Duration => this.End - this.Start;

        public DateTime End { get; }

        public DateTime Start { get; }

        #endregion

        #region Public Methods and Operators

        public static DateTimeSpan Parse(object source)
        {
            return source as DateTimeSpan;
        }

        #endregion
    }
}