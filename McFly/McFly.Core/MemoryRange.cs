﻿// ***********************************************************************
// Assembly         : McFly.Core
// Author           : @tysmithnet
// Created          : 03-26-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 03-26-2018
// ***********************************************************************
// <copyright file="MemoryRange.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace McFly.Core
{
    /// <summary>
    ///     Represents a memory range in virtual address space of a debugged target
    /// </summary>
    /// <seealso cref="System.IEquatable{McFly.Core.MemoryRange}" />
    /// <seealso cref="System.IComparable{McFly.Core.MemoryRange}" />
    /// <seealso cref="System.IComparable" />
    [DebuggerDisplay("{Low:X}:{High:X}")]
    public class MemoryRange : IEquatable<MemoryRange>, IComparable<MemoryRange>, IComparable
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MemoryRange" /> class.
        /// </summary>
        internal MemoryRange()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MemoryRange" /> class.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">low > high</exception>
        public MemoryRange(ulong low, ulong high)
        {
            if (low > high)
                throw new ArgumentOutOfRangeException(
                    $"Low memory address cannot be greater than the high memory address");

            Low = low;
            High = high;
        }

        /// <summary>
        ///     Gets the low address.
        /// </summary>
        /// <value>The low.</value>
        public ulong Low { get; }

        /// <summary>
        ///     Gets the high address.
        /// </summary>
        /// <value>The high.</value>
        public ulong High { get; }

        /// <summary>
        ///     Compares to.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentException">MemoryRange</exception>
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (!(obj is MemoryRange)) throw new ArgumentException($"Object must be of type {nameof(MemoryRange)}");
            return CompareTo((MemoryRange) obj);
        }

        /// <summary>
        ///     Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(MemoryRange other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var lowComparison = Low.CompareTo(other.Low);
            if (lowComparison != 0) return lowComparison;
            return High.CompareTo(other.High);
        }

        /// <summary>
        ///     Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if both MemoryRange are logically equivalent, <c>false</c> otherwise.</returns>
        public bool Equals(MemoryRange other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Low == other.Low && High == other.High;
        }

        /// <summary>
        ///     Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((MemoryRange) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Low.GetHashCode() * 397) ^ High.GetHashCode();
            }
        }

        /// <summary>
        ///     Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(MemoryRange left, MemoryRange right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(MemoryRange left, MemoryRange right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Implements the &lt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(MemoryRange left, MemoryRange right)
        {
            return Comparer<MemoryRange>.Default.Compare(left, right) < 0;
        }

        /// <summary>
        ///     Implements the &gt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(MemoryRange left, MemoryRange right)
        {
            return Comparer<MemoryRange>.Default.Compare(left, right) > 0;
        }

        /// <summary>
        ///     Implements the &lt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(MemoryRange left, MemoryRange right)
        {
            return Comparer<MemoryRange>.Default.Compare(left, right) <= 0;
        }

        /// <summary>
        ///     Implements the &gt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(MemoryRange left, MemoryRange right)
        {
            return Comparer<MemoryRange>.Default.Compare(left, right) >= 0;
        }
    }
}