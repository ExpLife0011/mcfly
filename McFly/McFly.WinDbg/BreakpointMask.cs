﻿// ***********************************************************************
// Assembly         : McFly.Core
// Author           : @tysmithnet
// Created          : 03-26-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-25-2018
// ***********************************************************************
// <copyright file="BreakpointMask.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text.RegularExpressions;

namespace McFly.WinDbg
{
    /// <summary>
    ///     Class BreakpointMask.
    /// </summary>
    /// <seealso cref="IBreakpoint" />
    /// <seealso cref="BreakpointMask" />
    public class BreakpointMask : IEquatable<BreakpointMask>
        , IBreakpoint
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BreakpointMask" /> class.
        /// </summary>
        /// <param name="moduleMask">The module mask.</param>
        /// <param name="functionMask">The function mask.</param>
        public BreakpointMask(string moduleMask, string functionMask)
        {
            ModuleMask = moduleMask ?? "*";
            FunctionMask = functionMask ?? "*";
        }

        /// <summary>
        ///     Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(BreakpointMask other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(ModuleMask, other.ModuleMask) && string.Equals(FunctionMask, other.FunctionMask);
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
            return Equals((BreakpointMask) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((ModuleMask != null ? ModuleMask.GetHashCode() : 0) * 397) ^
                       (FunctionMask != null ? FunctionMask.GetHashCode() : 0);
            }
        }

        /// <summary>
        ///     Parses the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>BreakpointMask.</returns>
        /// <exception cref="ArgumentNullException">input</exception>
        /// <exception cref="FormatException"></exception>
        public static BreakpointMask Parse(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var match = Regex.Match(input, @"(?<mod>[\w\*]+)!(?<fun>[\w\*]+)");
            if (!match.Success)
                throw new FormatException(
                    $"Input could not be parsed as a breakpoint mask.. should be in form mod!fun, *!fun, *!*create* but found: {input}");
            var mod = match.Groups["mod"].Value;
            var fun = match.Groups["fun"].Value;
            return new BreakpointMask(mod, fun);
        }

        /// <summary>
        ///     Sets the breakpoint.
        /// </summary>
        /// <param name="breakpointFacade">The breakpoint facade.</param>
        public void SetBreakpoint(IBreakpointFacade breakpointFacade)
        {
            breakpointFacade.SetBreakpointByMask(ModuleMask, FunctionMask);
        }

        /// <summary>
        ///     Gets the function mask.
        /// </summary>
        /// <value>The function mask.</value>
        public string FunctionMask { get; }

        /// <summary>
        ///     Gets the module mask.
        /// </summary>
        /// <value>The module mask.</value>
        public string ModuleMask { get; }
    }
}