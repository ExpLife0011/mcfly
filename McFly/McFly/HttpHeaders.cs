﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace McFly
{
    /// <summary>
    ///     Class HttpHeaders.
    /// </summary>
    /// <seealso cref="string" />
    /// <seealso cref="HttpHeaders" />
    public class HttpHeaders : Dictionary<string, string>, IEquatable<HttpHeaders>
    {
        /// <summary>
        ///     Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(HttpHeaders other)
        {
            return Count == other.Count && !this.Except(other).Any();
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
            return Equals((HttpHeaders) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 0;
                foreach (var keyValuePair in this)
                {
                    hashCode ^= keyValuePair.Key.GetHashCode();
                    hashCode ^= keyValuePair.Value.GetHashCode();
                    hashCode *= 1331553;
                }
                return hashCode;
            }
        }

        /// <summary>
        ///     Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(HttpHeaders left, HttpHeaders right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(HttpHeaders left, HttpHeaders right)
        {
            return !Equals(left, right);
        }
    }
}