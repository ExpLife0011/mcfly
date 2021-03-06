﻿// ***********************************************************************
// Assembly         : mcfly
// Author           : @tysmithnet
// Created          : 03-10-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-03-2018
// ***********************************************************************
// <copyright file="DisassemblyLine.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;

namespace McFly.Core
{
    /// <summary>
    ///     Represents a line of disassembly
    ///     This is what you would expect from the command "u rip L1"
    /// </summary>
    public class DisassemblyLine
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DisassemblyLine" /> class.
        /// </summary>
        public DisassemblyLine()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DisassemblyLine" /> class.
        /// </summary>
        /// <param name="instructionAddress">The instruction address.</param>
        /// <param name="opCode">The op code.</param>
        /// <param name="opCodeMnemonic">The op code mnemonic.</param>
        /// <param name="disassemblyNote">The disassembly note.</param>
        /// <exception cref="ArgumentNullException">
        ///     opCode
        ///     or
        ///     opCodeMnemonic
        ///     or
        ///     disassemblyNote
        /// </exception>
        public DisassemblyLine(ulong? instructionAddress, byte[] opCode, string opCodeMnemonic, string disassemblyNote)
        {
            InstructionAddress = instructionAddress;
            OpCode = opCode;
            OpCodeMnemonic = opCodeMnemonic?.Trim();
            DisassemblyNote = disassemblyNote?.Trim();
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
            return Equals((DisassemblyLine) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = InstructionAddress.GetHashCode();
                if (OpCode.Any())
                    hashCode = (hashCode * 397) ^ (OpCode != null ? OpCode.Aggregate((b, b1) => (byte) (b ^ b1)) : 0);
                hashCode = (hashCode * 397) ^ (OpCodeMnemonic != null ? OpCodeMnemonic.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DisassemblyNote != null ? DisassemblyNote.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary>
        ///     Determines whether the specified <see cref="DisassemblyLine" /> is equal to this instance.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected bool Equals(DisassemblyLine other)
        {
            var inst = InstructionAddress == other.InstructionAddress;
            var seq = OpCode.SequenceEqual(other.OpCode);
            var mnem = OpCodeMnemonic == other.OpCodeMnemonic;
            var note = DisassemblyNote == other.DisassemblyNote;
            return inst && seq && mnem && note;
        }

        /// <summary>
        ///     Gets the disassembly note.
        /// </summary>
        /// <value>The disassembly note.</value>
        public string DisassemblyNote { get; set; }

        /// <summary>
        ///     Gets the instruction address.
        /// </summary>
        /// <value>The instruction address.</value>
        public ulong? InstructionAddress { get; set; }

        /// <summary>
        ///     Gets the op code.
        /// </summary>
        /// <value>The op code.</value>
        public byte[] OpCode { get; set; }

        /// <summary>
        ///     Gets the op code mnemonic.
        /// </summary>
        /// <value>The op code mnemonic.</value>
        public string OpCodeMnemonic { get; set; }
    }
}