﻿// ***********************************************************************
// Assembly         : McFly.Core
// Author           : @tsmithnet
// Created          : 02-28-2018
//
// Last Modified By : @tsmithnet
// Last Modified On : 04-16-2018
// ***********************************************************************
// <copyright file="RegisterSet.cs" company="McFly.Core">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace McFly.Core
{
    /// <summary>
    ///     Represents the collection of all register values at a particular instance in time for a specific thread
    /// </summary>
    /// <seealso cref="System.IEquatable{McFly.Core.RegisterSet}" />
    public class RegisterSet : IEquatable<RegisterSet>
    {
        /// <summary>
        ///     The ST0
        /// </summary>
        private byte[] _st0;

        /// <summary>
        ///     The ST1
        /// </summary>
        private byte[] _st1;

        /// <summary>
        ///     The ST2
        /// </summary>
        private byte[] _st2;

        /// <summary>
        ///     The ST3
        /// </summary>
        private byte[] _st3;

        /// <summary>
        ///     The ST4
        /// </summary>
        private byte[] _st4;

        /// <summary>
        ///     The ST5
        /// </summary>
        private byte[] _st5;

        /// <summary>
        ///     The ST6
        /// </summary>
        private byte[] _st6;

        /// <summary>
        ///     The ST7
        /// </summary>
        private byte[] _st7;

        /// <summary>
        ///     The ymm0
        /// </summary>
        private byte[] _ymm0;

        /// <summary>
        ///     The ymm1
        /// </summary>
        private byte[] _ymm1;

        /// <summary>
        ///     The ymm10
        /// </summary>
        private byte[] _ymm10;

        /// <summary>
        ///     The ymm11
        /// </summary>
        private byte[] _ymm11;

        /// <summary>
        ///     The ymm12
        /// </summary>
        private byte[] _ymm12;

        /// <summary>
        ///     The ymm13
        /// </summary>
        private byte[] _ymm13;

        /// <summary>
        ///     The ymm14
        /// </summary>
        private byte[] _ymm14;

        /// <summary>
        ///     The ymm15
        /// </summary>
        private byte[] _ymm15;

        /// <summary>
        ///     The ymm2
        /// </summary>
        private byte[] _ymm2;

        /// <summary>
        ///     The ymm3
        /// </summary>
        private byte[] _ymm3;

        /// <summary>
        ///     The ymm4
        /// </summary>
        private byte[] _ymm4;

        /// <summary>
        ///     The ymm5
        /// </summary>
        private byte[] _ymm5;

        /// <summary>
        ///     The ymm6
        /// </summary>
        private byte[] _ymm6;

        /// <summary>
        ///     The ymm7
        /// </summary>
        private byte[] _ymm7;

        /// <summary>
        ///     The ymm8
        /// </summary>
        private byte[] _ymm8;

        /// <summary>
        ///     The ymm9
        /// </summary>
        private byte[] _ymm9;

        /// <summary>
        ///     Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <inheritdoc />
        public bool Equals(RegisterSet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Brfrom == other.Brfrom &&
                   Brto == other.Brto &&
                   Cs == other.Cs &&
                   Dr0 == other.Dr0 &&
                   Dr1 == other.Dr1 &&
                   Dr2 == other.Dr2 &&
                   Dr3 == other.Dr3 &&
                   Dr6 == other.Dr6 &&
                   Dr7 == other.Dr7 &&
                   Ds == other.Ds &&
                   Efl == other.Efl &&
                   Es == other.Es &&
                   Exfrom == other.Exfrom &&
                   Exto == other.Exto &&
                   Fpcw == other.Fpcw &&
                   Fpsw == other.Fpsw &&
                   Fptw == other.Fptw &&
                   Fopcode == other.Fopcode &&
                   Fpip == other.Fpip &&
                   Fpipsel == other.Fpipsel &&
                   Fpdp == other.Fpdp &&
                   Fpdpsel == other.Fpdpsel &&
                   Fs == other.Fs &&
                   Gs == other.Gs &&
                   Mm0 == other.Mm0 &&
                   Mm1 == other.Mm1 &&
                   Mm2 == other.Mm2 &&
                   Mm3 == other.Mm3 &&
                   Mm4 == other.Mm4 &&
                   Mm5 == other.Mm5 &&
                   Mm6 == other.Mm6 &&
                   Mm7 == other.Mm7 &&
                   Mxcsr == other.Mxcsr &&
                   (St0 == other.St0 || St0 != null && other.St0 != null && St0.SequenceEqual(other.St0)) &&
                   (St1 == other.St1 || St1 != null && other.St1 != null && St1.SequenceEqual(other.St1)) &&
                   (St2 == other.St2 || St2 != null && other.St2 != null && St2.SequenceEqual(other.St2)) &&
                   (St3 == other.St3 || St3 != null && other.St3 != null && St3.SequenceEqual(other.St3)) &&
                   (St4 == other.St4 || St4 != null && other.St4 != null && St4.SequenceEqual(other.St4)) &&
                   (St5 == other.St5 || St5 != null && other.St5 != null && St5.SequenceEqual(other.St5)) &&
                   (St6 == other.St6 || St6 != null && other.St6 != null && St6.SequenceEqual(other.St6)) &&
                   (St7 == other.St7 || St7 != null && other.St7 != null && St7.SequenceEqual(other.St7)) &&
                   R10 == other.R10 &&
                   R11 == other.R11 &&
                   R12 == other.R12 &&
                   R13 == other.R13 &&
                   R14 == other.R14 &&
                   R15 == other.R15 &&
                   R8 == other.R8 &&
                   R9 == other.R9 &&
                   Rax == other.Rax &&
                   Rbp == other.Rbp &&
                   Rbx == other.Rbx &&
                   Rcx == other.Rcx &&
                   Rdi == other.Rdi &&
                   Rdx == other.Rdx &&
                   Rip == other.Rip &&
                   Rsi == other.Rsi &&
                   Rsp == other.Rsp &&
                   Ss == other.Ss &&
                   (Ymm0 == other.Ymm0 || Ymm0 != null && other.Ymm0 != null && Ymm0.SequenceEqual(other.Ymm0)) &&
                   (Ymm1 == other.Ymm1 || Ymm1 != null && other.Ymm1 != null && Ymm1.SequenceEqual(other.Ymm1)) &&
                   (Ymm2 == other.Ymm2 || Ymm2 != null && other.Ymm2 != null && Ymm2.SequenceEqual(other.Ymm2)) &&
                   (Ymm3 == other.Ymm3 || Ymm3 != null && other.Ymm3 != null && Ymm3.SequenceEqual(other.Ymm3)) &&
                   (Ymm4 == other.Ymm4 || Ymm4 != null && other.Ymm4 != null && Ymm4.SequenceEqual(other.Ymm4)) &&
                   (Ymm5 == other.Ymm5 || Ymm5 != null && other.Ymm5 != null && Ymm5.SequenceEqual(other.Ymm5)) &&
                   (Ymm6 == other.Ymm6 || Ymm6 != null && other.Ymm6 != null && Ymm6.SequenceEqual(other.Ymm6)) &&
                   (Ymm7 == other.Ymm7 || Ymm7 != null && other.Ymm7 != null && Ymm7.SequenceEqual(other.Ymm7)) &&
                   (Ymm8 == other.Ymm8 || Ymm8 != null && other.Ymm8 != null && Ymm8.SequenceEqual(other.Ymm8)) &&
                   (Ymm9 == other.Ymm9 || Ymm9 != null && other.Ymm9 != null && Ymm9.SequenceEqual(other.Ymm9)) &&
                   (Ymm10 == other.Ymm10 || Ymm10 != null && other.Ymm10 != null && Ymm10.SequenceEqual(other.Ymm10)) &&
                   (Ymm11 == other.Ymm11 || Ymm11 != null && other.Ymm11 != null && Ymm11.SequenceEqual(other.Ymm11)) &&
                   (Ymm12 == other.Ymm12 || Ymm12 != null && other.Ymm12 != null && Ymm12.SequenceEqual(other.Ymm12)) &&
                   (Ymm13 == other.Ymm13 || Ymm13 != null && other.Ymm13 != null && Ymm13.SequenceEqual(other.Ymm13)) &&
                   (Ymm14 == other.Ymm14 || Ymm14 != null && other.Ymm14 != null && Ymm14.SequenceEqual(other.Ymm14)) &&
                   (Ymm15 == other.Ymm15 || Ymm15 != null && other.Ymm15 != null && Ymm15.SequenceEqual(other.Ymm15));
        }

        /// <summary>
        ///     Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RegisterSet) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 46573 ^
                               Brfrom?.GetHashCode() ?? 0 ^
                               Brto?.GetHashCode() ?? 0 ^
                               Cs?.GetHashCode() ?? 0 ^
                               Dr0?.GetHashCode() ?? 0 ^
                               Dr1?.GetHashCode() ?? 0 ^
                               Dr2?.GetHashCode() ?? 0 ^
                               Dr3?.GetHashCode() ?? 0 ^
                               Dr6?.GetHashCode() ?? 0 ^
                               Dr7?.GetHashCode() ?? 0 ^
                               Ds?.GetHashCode() ?? 0 ^
                               Efl?.GetHashCode() ?? 0 ^
                               Es?.GetHashCode() ?? 0 ^
                               Exfrom?.GetHashCode() ?? 0 ^
                               Exto?.GetHashCode() ?? 0 ^
                               Fpcw?.GetHashCode() ?? 0 ^
                               Fpsw?.GetHashCode() ?? 0 ^
                               Fptw?.GetHashCode() ?? 0 ^
                               Fopcode?.GetHashCode() ?? 0 ^
                               Fpip?.GetHashCode() ?? 0 ^
                               Fpipsel?.GetHashCode() ?? 0 ^
                               Fpdp?.GetHashCode() ?? 0 ^
                               Fpdpsel?.GetHashCode() ?? 0 ^
                               Fs?.GetHashCode() ?? 0 ^
                               Gs?.GetHashCode() ?? 0 ^
                               Mm0?.GetHashCode() ?? 0 ^
                               Mm1?.GetHashCode() ?? 0 ^
                               Mm2?.GetHashCode() ?? 0 ^
                               Mm3?.GetHashCode() ?? 0 ^
                               Mm4?.GetHashCode() ?? 0 ^
                               Mm5?.GetHashCode() ?? 0 ^
                               Mm6?.GetHashCode() ?? 0 ^
                               Mm7?.GetHashCode() ?? 0 ^
                               Mxcsr?.GetHashCode() ?? 0 ^
                               R10?.GetHashCode() ?? 0 ^
                               R11?.GetHashCode() ?? 0 ^
                               R12?.GetHashCode() ?? 0 ^
                               R13?.GetHashCode() ?? 0 ^
                               R14?.GetHashCode() ?? 0 ^
                               R15?.GetHashCode() ?? 0 ^
                               R8?.GetHashCode() ?? 0 ^
                               R9?.GetHashCode() ?? 0 ^
                               Rax?.GetHashCode() ?? 0 ^
                               Rbp?.GetHashCode() ?? 0 ^
                               Rbx?.GetHashCode() ?? 0 ^
                               Rcx?.GetHashCode() ?? 0 ^
                               Rdi?.GetHashCode() ?? 0 ^
                               Rdx?.GetHashCode() ?? 0 ^
                               Rip?.GetHashCode() ?? 0 ^
                               Rsi?.GetHashCode() ?? 0 ^
                               Rsp?.GetHashCode() ?? 0 ^
                               Ss?.GetHashCode() ?? 0;
                St0?.ToList().ForEach(b => hashCode ^= b);
                St1?.ToList().ForEach(b => hashCode ^= b);
                St2?.ToList().ForEach(b => hashCode ^= b);
                St3?.ToList().ForEach(b => hashCode ^= b);
                St4?.ToList().ForEach(b => hashCode ^= b);
                St5?.ToList().ForEach(b => hashCode ^= b);
                St6?.ToList().ForEach(b => hashCode ^= b);
                St7?.ToList().ForEach(b => hashCode ^= b);
                Ymm0?.ToList().ForEach(b => hashCode ^= b);
                Ymm1?.ToList().ForEach(b => hashCode ^= b);
                Ymm2?.ToList().ForEach(b => hashCode ^= b);
                Ymm3?.ToList().ForEach(b => hashCode ^= b);
                Ymm4?.ToList().ForEach(b => hashCode ^= b);
                Ymm5?.ToList().ForEach(b => hashCode ^= b);
                Ymm6?.ToList().ForEach(b => hashCode ^= b);
                Ymm7?.ToList().ForEach(b => hashCode ^= b);
                Ymm8?.ToList().ForEach(b => hashCode ^= b);
                Ymm9?.ToList().ForEach(b => hashCode ^= b);
                Ymm10?.ToList().ForEach(b => hashCode ^= b);
                Ymm11?.ToList().ForEach(b => hashCode ^= b);
                Ymm12?.ToList().ForEach(b => hashCode ^= b);
                Ymm13?.ToList().ForEach(b => hashCode ^= b);
                Ymm14?.ToList().ForEach(b => hashCode ^= b);
                Ymm15?.ToList().ForEach(b => hashCode ^= b);

                return hashCode;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is af.
        /// </summary>
        /// <value><c>null</c> if [af] contains no value, <c>true</c> if [af]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Af
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0010) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (!Efl.HasValue)
                    Efl = 0;
                uint mask = 0x0010;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the ah.
        /// </summary>
        /// <value>The ah.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Ah
        {
            get => Ax?.Hi8();
            set
            {
                if (!value.HasValue) return;
                if (Rax == null)
                    Rax = 0;
                Ax = Ax?.Hi8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the al.
        /// </summary>
        /// <value>The al.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Al
        {
            get => Ax?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rax == null)
                    Rax = 0;
                Ax = Ax?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the ax.
        /// </summary>
        /// <value>The ax.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Ax
        {
            get => Eax?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rax == null)
                    Rax = 0;
                Eax = Eax?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the bh.
        /// </summary>
        /// <value>The bh.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Bh
        {
            get => Bx?.Hi8();
            set
            {
                if (!value.HasValue) return;
                if (Rbx == null)
                    Rbx = 0;
                Bx = Bx?.Hi8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the bl.
        /// </summary>
        /// <value>The bl.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Bl
        {
            get => Bx?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rbx == null)
                    Rbx = 0;
                Bx = Bx?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the bp.
        /// </summary>
        /// <value>The bp.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Bp
        {
            get => Ebp?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rbp == null)
                    Rbp = 0;
                Ebp = Ebp?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the BPL.
        /// </summary>
        /// <value>The BPL.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Bpl
        {
            get => Bp?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rbp == null)
                    Rbp = 0;
                Bp = Bp?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the brfrom.
        /// </summary>
        /// <value>The brfrom.</value>
        public ulong? Brfrom { get; set; }

        /// <summary>
        ///     Gets or sets the brto.
        /// </summary>
        /// <value>The brto.</value>
        public ulong? Brto { get; set; }

        /// <summary>
        ///     Gets or sets the bx.
        /// </summary>
        /// <value>The bx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Bx
        {
            get => Ebx?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Ebx == null)
                    Ebx = 0;
                Ebx = Ebx?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is cf.
        /// </summary>
        /// <value><c>null</c> if [cf] contains no value, <c>true</c> if [cf]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Cf
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0001) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0001;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the ch.
        /// </summary>
        /// <value>The ch.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Ch
        {
            get => Cx?.Hi8();
            set
            {
                if (!value.HasValue) return;
                if (Rcx == null)
                    Rcx = 0;
                Cx = Cx?.Hi8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the cl.
        /// </summary>
        /// <value>The cl.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Cl
        {
            get => Cx?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rcx == null)
                    Rcx = 0;
                Cx = Cx?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the cs.
        /// </summary>
        /// <value>The cs.</value>
        public ushort? Cs { get; set; }

        /// <summary>
        ///     Gets or sets the cx.
        /// </summary>
        /// <value>The cx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Cx
        {
            get => Ecx?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rcx == null)
                    Rcx = 0;
                Ecx = Ecx?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is df.
        /// </summary>
        /// <value><c>null</c> if [df] contains no value, <c>true</c> if [df]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Df
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0400) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0400;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the dh.
        /// </summary>
        /// <value>The dh.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Dh
        {
            get => Dx?.Hi8();
            set
            {
                if (!value.HasValue) return;
                if (Rdx == null)
                    Rdx = 0;
                Dx = Dx?.Hi8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the di.
        /// </summary>
        /// <value>The di.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Di
        {
            get => Edi?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rdi == null)
                    Rdi = 0;
                Edi = Edi?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the dil.
        /// </summary>
        /// <value>The dil.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Dil
        {
            get => Di?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rdi == null)
                    Rdi = 0;
                Di = Di?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the dl.
        /// </summary>
        /// <value>The dl.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Dl
        {
            get => Dx?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rdx == null)
                    Rdx = 0;
                Dx = Dx?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the DR0.
        /// </summary>
        /// <value>The DR0.</value>
        public ulong? Dr0 { get; set; }

        /// <summary>
        ///     Gets or sets the DR1.
        /// </summary>
        /// <value>The DR1.</value>
        public ulong? Dr1 { get; set; }

        /// <summary>
        ///     Gets or sets the DR2.
        /// </summary>
        /// <value>The DR2.</value>
        public ulong? Dr2 { get; set; }

        /// <summary>
        ///     Gets or sets the DR3.
        /// </summary>
        /// <value>The DR3.</value>
        public ulong? Dr3 { get; set; }

        /// <summary>
        ///     Gets or sets the DR6.
        /// </summary>
        /// <value>The DR6.</value>
        public ulong? Dr6 { get; set; }

        /// <summary>
        ///     Gets or sets the DR7.
        /// </summary>
        /// <value>The DR7.</value>
        public ulong? Dr7 { get; set; }

        /// <summary>
        ///     Gets or sets the ds.
        /// </summary>
        /// <value>The ds.</value>
        public ushort? Ds { get; set; }

        /// <summary>
        ///     Gets or sets the dx.
        /// </summary>
        /// <value>The dx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Dx
        {
            get => Edx?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rdx == null)
                    Rdx = 0;
                Edx = Edx?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the eax.
        /// </summary>
        /// <value>The eax.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Eax
        {
            get => Rax?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rax == null)
                    Rax = 0;
                Rax = Rax?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the ebp.
        /// </summary>
        /// <value>The ebp.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Ebp
        {
            get => Rbp?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rbp == null)
                    Rbp = 0;
                Rbp = Rbp?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the ebx.
        /// </summary>
        /// <value>The ebx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Ebx
        {
            get => Rbx?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rbx == null)
                    Rbx = 0;
                Rbx = Rbx?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the ecx.
        /// </summary>
        /// <value>The ecx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Ecx
        {
            get => Rcx?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rcx == null)
                    Rcx = 0;
                Rcx = Rcx?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the edi.
        /// </summary>
        /// <value>The edi.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Edi
        {
            get => Rdi?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rdi == null)
                    Rdi = 0;
                Rdi = Rdi?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the edx.
        /// </summary>
        /// <value>The edx.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Edx
        {
            get => Rdx?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rdx == null)
                    Rdx = 0;
                Rdx = Rdx?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the efl.
        /// </summary>
        /// <value>The efl.</value>
        public uint? Efl { get; set; }

        /// <summary>
        ///     Gets or sets the eip.
        /// </summary>
        /// <value>The eip.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Eip
        {
            get => Rip?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rip == null)
                    Rip = 0;
                Rip = Rip?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the es.
        /// </summary>
        /// <value>The es.</value>
        public ushort? Es { get; set; }

        /// <summary>
        ///     Gets or sets the esi.
        /// </summary>
        /// <value>The esi.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Esi
        {
            get => Rsi?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rsi == null)
                    Rsi = 0;
                Rsi = Rsi?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the esp.
        /// </summary>
        /// <value>The esp.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? Esp
        {
            get => Rsp?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (Rsp == null)
                    Rsp = 0;
                Rsp = Rsp?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the exfrom.
        /// </summary>
        /// <value>The exfrom.</value>
        public ulong? Exfrom { get; set; }

        /// <summary>
        ///     Gets or sets the exto.
        /// </summary>
        /// <value>The exto.</value>
        public ulong? Exto { get; set; }

        /// <summary>
        ///     Gets or sets the fl.
        /// </summary>
        /// <value>The fl.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Fl
        {
            get => Efl?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                Efl = Efl?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the fopcode.
        /// </summary>
        /// <value>The fopcode.</value>
        public ushort? Fopcode { get; set; }

        /// <summary>
        ///     Gets or sets the FPCW.
        /// </summary>
        /// <value>The FPCW.</value>
        public ushort? Fpcw { get; set; }

        /// <summary>
        ///     Gets or sets the FPDP.
        /// </summary>
        /// <value>The FPDP.</value>
        public uint? Fpdp { get; set; }

        /// <summary>
        ///     Gets or sets the fpdpsel.
        /// </summary>
        /// <value>The fpdpsel.</value>
        public uint? Fpdpsel { get; set; }

        /// <summary>
        ///     Gets or sets the fpip.
        /// </summary>
        /// <value>The fpip.</value>
        public uint? Fpip { get; set; }

        /// <summary>
        ///     Gets or sets the fpipsel.
        /// </summary>
        /// <value>The fpipsel.</value>
        public uint? Fpipsel { get; set; }

        /// <summary>
        ///     Gets or sets the FPSW.
        /// </summary>
        /// <value>The FPSW.</value>
        public ushort? Fpsw { get; set; }

        /// <summary>
        ///     Gets or sets the FPTW.
        /// </summary>
        /// <value>The FPTW.</value>
        public ushort? Fptw { get; set; }

        /// <summary>
        ///     Gets or sets the fs.
        /// </summary>
        /// <value>The fs.</value>
        public ushort? Fs { get; set; }

        /// <summary>
        ///     Gets or sets the gs.
        /// </summary>
        /// <value>The gs.</value>
        public ushort? Gs { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is if.
        /// </summary>
        /// <value><c>null</c> if [if] contains no value, <c>true</c> if [if]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? If
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0200) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0200;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the iopl.
        /// </summary>
        /// <value>The iopl.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Iopl
        {
            get => Efl.HasValue ? (byte?) ((Efl & 0x3000) >> 12) : null;
            set
            {
                if (!value.HasValue)
                    return;
                if (Efl == null)
                    Efl = 0;
                Efl &= unchecked((uint) ~12288);
                Efl |= (uint) (value.Value << 12);
            }
        }

        /// <summary>
        ///     Gets or sets the ip.
        /// </summary>
        /// <value>The ip.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Ip
        {
            get => Eip?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rip == null)
                    Rip = 0;
                Eip = Eip?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the MM0.
        /// </summary>
        /// <value>The MM0.</value>
        public ulong? Mm0 { get; set; }

        /// <summary>
        ///     Gets or sets the MM1.
        /// </summary>
        /// <value>The MM1.</value>
        public ulong? Mm1 { get; set; }

        /// <summary>
        ///     Gets or sets the MM2.
        /// </summary>
        /// <value>The MM2.</value>
        public ulong? Mm2 { get; set; }

        /// <summary>
        ///     Gets or sets the MM3.
        /// </summary>
        /// <value>The MM3.</value>
        public ulong? Mm3 { get; set; }

        /// <summary>
        ///     Gets or sets the MM4.
        /// </summary>
        /// <value>The MM4.</value>
        public ulong? Mm4 { get; set; }

        /// <summary>
        ///     Gets or sets the MM5.
        /// </summary>
        /// <value>The MM5.</value>
        public ulong? Mm5 { get; set; }

        /// <summary>
        ///     Gets or sets the MM6.
        /// </summary>
        /// <value>The MM6.</value>
        public ulong? Mm6 { get; set; }

        /// <summary>
        ///     Gets or sets the MM7.
        /// </summary>
        /// <value>The MM7.</value>
        public ulong? Mm7 { get; set; }

        /// <summary>
        ///     Gets or sets the MXCSR.
        /// </summary>
        /// <value>The MXCSR.</value>
        public uint? Mxcsr { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is of.
        /// </summary>
        /// <value><c>null</c> if [of] contains no value, <c>true</c> if [of]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Of
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0800) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0800;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is pf.
        /// </summary>
        /// <value><c>null</c> if [pf] contains no value, <c>true</c> if [pf]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Pf
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0004) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0004;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the R10.
        /// </summary>
        /// <value>The R10.</value>
        public ulong? R10 { get; set; }

        /// <summary>
        ///     Gets or sets the R10B.
        /// </summary>
        /// <value>The R10B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R10b
        {
            get => R10w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R10 == null)
                    R10 = 0;
                R10w = R10w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R10D.
        /// </summary>
        /// <value>The R10D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R10d
        {
            get => R10?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R10 == null)
                    R10 = 0;
                R10 = R10?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R10W.
        /// </summary>
        /// <value>The R10W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R10w
        {
            get => R10d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R10 == null)
                    R10 = 0;
                R10d = R10d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R11.
        /// </summary>
        /// <value>The R11.</value>
        public ulong? R11 { get; set; }

        /// <summary>
        ///     Gets or sets the R11B.
        /// </summary>
        /// <value>The R11B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R11b
        {
            get => R11w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R11 == null)
                    R11 = 0;
                R11w = R11w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R11D.
        /// </summary>
        /// <value>The R11D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R11d
        {
            get => R11?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R11 == null)
                    R11 = 0;
                R11 = R11?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R11W.
        /// </summary>
        /// <value>The R11W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R11w
        {
            get => R11d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R11 == null)
                    R11 = 0;
                R11d = R11d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R12.
        /// </summary>
        /// <value>The R12.</value>
        public ulong? R12 { get; set; }

        /// <summary>
        ///     Gets or sets the R12B.
        /// </summary>
        /// <value>The R12B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R12b
        {
            get => R12w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R12 == null)
                    R12 = 0;
                R12w = R12w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R12D.
        /// </summary>
        /// <value>The R12D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R12d
        {
            get => R12?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R12 == null)
                    R12 = 0;
                R12 = R12?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R12W.
        /// </summary>
        /// <value>The R12W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R12w
        {
            get => R12d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R12 == null)
                    R12 = 0;
                R12d = R12d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R13.
        /// </summary>
        /// <value>The R13.</value>
        public ulong? R13 { get; set; }

        /// <summary>
        ///     Gets or sets the R13B.
        /// </summary>
        /// <value>The R13B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R13b
        {
            get => R13w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R13 == null)
                    R13 = 0;
                R13w = R13w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R13D.
        /// </summary>
        /// <value>The R13D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R13d
        {
            get => R13?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R13 == null)
                    R13 = 0;
                R13 = R13?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R13W.
        /// </summary>
        /// <value>The R13W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R13w
        {
            get => R13d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R13 == null)
                    R13 = 0;
                R13d = R13d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R14.
        /// </summary>
        /// <value>The R14.</value>
        public ulong? R14 { get; set; }

        /// <summary>
        ///     Gets or sets the R14B.
        /// </summary>
        /// <value>The R14B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R14b
        {
            get => R14w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R14 == null)
                    R14 = 0;
                R14w = R14w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R14D.
        /// </summary>
        /// <value>The R14D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R14d
        {
            get => R14?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R14 == null)
                    R14 = 0;
                R14 = R14?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R14W.
        /// </summary>
        /// <value>The R14W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R14w
        {
            get => R14d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R14 == null)
                    R14 = 0;
                R14d = R14d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R15.
        /// </summary>
        /// <value>The R15.</value>
        public ulong? R15 { get; set; }

        /// <summary>
        ///     Gets or sets the R15B.
        /// </summary>
        /// <value>The R15B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R15b
        {
            get => R15w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R15 == null)
                    R15 = 0;
                R15w = R15w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R15D.
        /// </summary>
        /// <value>The R15D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R15d
        {
            get => R15?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R15 == null)
                    R15 = 0;
                R15 = R15?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R15W.
        /// </summary>
        /// <value>The R15W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]

        public ushort? R15w
        {
            get => R15d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R15 == null)
                    R15 = 0;
                R15d = R15d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the r8.
        /// </summary>
        /// <value>The r8.</value>
        public ulong? R8 { get; set; }

        /// <summary>
        ///     Gets or sets the R8B.
        /// </summary>
        /// <value>The R8B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R8b
        {
            get => R8w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R8 == null)
                    R8 = 0;
                R8w = R8w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R8D.
        /// </summary>
        /// <value>The R8D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R8d
        {
            get => R8?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R8 == null)
                    R8 = 0;
                R8 = R8?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R8W.
        /// </summary>
        /// <value>The R8W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R8w
        {
            get => R8d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R8 == null)
                    R8 = 0;
                R8d = R8d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the r9.
        /// </summary>
        /// <value>The r9.</value>
        public ulong? R9 { get; set; }

        /// <summary>
        ///     Gets or sets the R9B.
        /// </summary>
        /// <value>The R9B.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? R9b
        {
            get => R9w?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (R9 == null)
                    R9 = 0;
                R9w = R9w?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R9D.
        /// </summary>
        /// <value>The R9D.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public uint? R9d
        {
            get => R9?.Lo32();
            set
            {
                if (!value.HasValue) return;
                if (R9 == null)
                    R9 = 0;
                R9 = R9?.Lo32(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the R9W.
        /// </summary>
        /// <value>The R9W.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? R9w
        {
            get => R9d?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (R9 == null)
                    R9 = 0;
                R9d = R9d?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the rax.
        /// </summary>
        /// <value>The rax.</value>
        public ulong? Rax { get; set; }

        /// <summary>
        ///     Gets or sets the RBP.
        /// </summary>
        /// <value>The RBP.</value>
        public ulong? Rbp { get; set; }

        /// <summary>
        ///     Gets or sets the RBX.
        /// </summary>
        /// <value>The RBX.</value>
        public ulong? Rbx { get; set; }

        /// <summary>
        ///     Gets or sets the RCX.
        /// </summary>
        /// <value>The RCX.</value>
        public ulong? Rcx { get; set; }

        /// <summary>
        ///     Gets or sets the rdi.
        /// </summary>
        /// <value>The rdi.</value>
        public ulong? Rdi { get; set; }

        /// <summary>
        ///     Gets or sets the RDX.
        /// </summary>
        /// <value>The RDX.</value>
        public ulong? Rdx { get; set; }

        /// <summary>
        ///     Gets or sets the rip.
        /// </summary>
        /// <value>The rip.</value>
        public ulong? Rip { get; set; }

        /// <summary>
        ///     Gets or sets the rsi.
        /// </summary>
        /// <value>The rsi.</value>
        public ulong? Rsi { get; set; }

        /// <summary>
        ///     Gets or sets the RSP.
        /// </summary>
        /// <value>The RSP.</value>
        public ulong? Rsp { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is sf.
        /// </summary>
        /// <value><c>null</c> if [sf] contains no value, <c>true</c> if [sf]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Sf
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0080) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (Efl == null)
                    Efl = 0;
                uint mask = 0x0080;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the si.
        /// </summary>
        /// <value>The si.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Si
        {
            get => Esi?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rsi == null)
                    Rsi = 0;
                Esi = Esi?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the sil.
        /// </summary>
        /// <value>The sil.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Sil
        {
            get => Si?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rsi == null)
                    Rsi = 0;
                Si = Si?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the sp.
        /// </summary>
        /// <value>The sp.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ushort? Sp
        {
            get => Esp?.Lo16();
            set
            {
                if (!value.HasValue) return;
                if (Rsp == null)
                    Rsp = 0;
                Esp = Esp?.Lo16(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the SPL.
        /// </summary>
        /// <value>The SPL.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte? Spl
        {
            get => Sp?.Lo8();
            set
            {
                if (!value.HasValue) return;
                if (Rsp == null)
                    Rsp = 0;
                Sp = Sp?.Lo8(value.Value);
            }
        }

        /// <summary>
        ///     Gets or sets the ss.
        /// </summary>
        /// <value>The ss.</value>
        public uint? Ss { get; set; }

        /// <summary>
        ///     Gets or sets the ST0.
        /// </summary>
        /// <value>The ST0.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St0
        {
            get => _st0;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st0 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST1.
        /// </summary>
        /// <value>The ST1.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St1
        {
            get => _st1;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st1 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST2.
        /// </summary>
        /// <value>The ST2.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St2
        {
            get => _st2;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st2 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST3.
        /// </summary>
        /// <value>The ST3.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St3
        {
            get => _st3;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st3 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST4.
        /// </summary>
        /// <value>The ST4.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St4
        {
            get => _st4;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st4 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST5.
        /// </summary>
        /// <value>The ST5.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St5
        {
            get => _st5;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st5 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST6.
        /// </summary>
        /// <value>The ST6.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St6
        {
            get => _st6;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st6 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ST7.
        /// </summary>
        /// <value>The ST7.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] St7
        {
            get => _st7;
            set
            {
                if (value != null && value.Length != 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 10");
                _st7 = value;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is tf.
        /// </summary>
        /// <value><c>null</c> if [tf] contains no value, <c>true</c> if [tf]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Tf
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0100) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (!Efl.HasValue)
                    Efl = 0;
                uint mask = 0x0100;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is vif.
        /// </summary>
        /// <value><c>null</c> if [vif] contains no value, <c>true</c> if [vif]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Vif
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x00080000) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (!Efl.HasValue)
                    Efl = 0;
                uint mask = 0x00080000;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is vip.
        /// </summary>
        /// <value><c>null</c> if [vip] contains no value, <c>true</c> if [vip]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Vip
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x00100000) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (!Efl.HasValue)
                    Efl = 0;
                uint mask = 0x00100000;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }

        /// <summary>
        ///     Gets or sets the XMM0.
        /// </summary>
        /// <value>The XMM0.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm0
        {
            get => Ymm0?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm0 == null)
                    Ymm0 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm0[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM0H.
        /// </summary>
        /// <value>The XMM0H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm0h
        {
            get => Ymm0 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm0, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm0 == null)
                    Ymm0 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm0[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM0L.
        /// </summary>
        /// <value>The XMM0L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm0l
        {
            get => Ymm0 != null ? (ulong?) BitConverter.ToUInt64(Ymm0, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm0 == null)
                    Ymm0 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm0[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM1.
        /// </summary>
        /// <value>The XMM1.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm1
        {
            get => Ymm1?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm1 == null)
                    Ymm1 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm1[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM10.
        /// </summary>
        /// <value>The XMM10.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm10
        {
            get => Ymm10?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm10 == null)
                    Ymm10 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm10[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM10H.
        /// </summary>
        /// <value>The XMM10H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm10h
        {
            get => Ymm10 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm10, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm10 == null)
                    Ymm10 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm10[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM10L.
        /// </summary>
        /// <value>The XMM10L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm10l
        {
            get => Ymm10 != null ? (ulong?) BitConverter.ToUInt64(Ymm10, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm10 == null)
                    Ymm10 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm10[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM11.
        /// </summary>
        /// <value>The XMM11.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm11
        {
            get => Ymm11?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm11 == null)
                    Ymm11 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm11[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM11H.
        /// </summary>
        /// <value>The XMM11H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm11h
        {
            get => Ymm11 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm11, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm11 == null)
                    Ymm11 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm11[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM11L.
        /// </summary>
        /// <value>The XMM11L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm11l
        {
            get => Ymm11 != null ? (ulong?) BitConverter.ToUInt64(Ymm11, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm11 == null)
                    Ymm11 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm11[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM12.
        /// </summary>
        /// <value>The XMM12.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm12
        {
            get => Ymm12?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm12 == null)
                    Ymm12 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm12[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM12H.
        /// </summary>
        /// <value>The XMM12H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm12h
        {
            get => Ymm12 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm12, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm12 == null)
                    Ymm12 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm12[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM12L.
        /// </summary>
        /// <value>The XMM12L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm12l
        {
            get => Ymm12 != null ? (ulong?) BitConverter.ToUInt64(Ymm12, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm12 == null)
                    Ymm12 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm12[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM13.
        /// </summary>
        /// <value>The XMM13.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm13
        {
            get => Ymm13?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm13 == null)
                    Ymm13 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm13[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM13H.
        /// </summary>
        /// <value>The XMM13H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm13h
        {
            get => Ymm13 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm13, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm13 == null)
                    Ymm13 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm13[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM13L.
        /// </summary>
        /// <value>The XMM13L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm13l
        {
            get => Ymm13 != null ? (ulong?) BitConverter.ToUInt64(Ymm13, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm13 == null)
                    Ymm13 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm13[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM14.
        /// </summary>
        /// <value>The XMM14.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm14
        {
            get => Ymm14?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm14 == null)
                    Ymm14 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm14[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM14H.
        /// </summary>
        /// <value>The XMM14H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm14h
        {
            get => Ymm14 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm14, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm14 == null)
                    Ymm14 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm14[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM14L.
        /// </summary>
        /// <value>The XMM14L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm14l
        {
            get => Ymm14 != null ? (ulong?) BitConverter.ToUInt64(Ymm14, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm14 == null)
                    Ymm14 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm14[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM15.
        /// </summary>
        /// <value>The XMM15.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm15
        {
            get => Ymm15?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm15 == null)
                    Ymm15 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm15[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM15H.
        /// </summary>
        /// <value>The XMM15H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm15h
        {
            get => Ymm15 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm15, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm15 == null)
                    Ymm15 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm15[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM15L.
        /// </summary>
        /// <value>The XMM15L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm15l
        {
            get => Ymm15 != null ? (ulong?) BitConverter.ToUInt64(Ymm15, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm15 == null)
                    Ymm15 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm15[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM1H.
        /// </summary>
        /// <value>The XMM1H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm1h
        {
            get => Ymm1 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm1, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm1 == null)
                    Ymm1 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm1[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM1L.
        /// </summary>
        /// <value>The XMM1L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm1l
        {
            get => Ymm1 != null ? (ulong?) BitConverter.ToUInt64(Ymm1, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm1 == null)
                    Ymm1 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm1[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM2.
        /// </summary>
        /// <value>The XMM2.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm2
        {
            get => Ymm2?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm2 == null)
                    Ymm2 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm2[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM2H.
        /// </summary>
        /// <value>The XMM2H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm2h
        {
            get => Ymm2 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm2, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm2 == null)
                    Ymm2 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm2[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM2L.
        /// </summary>
        /// <value>The XMM2L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm2l
        {
            get => Ymm2 != null ? (ulong?) BitConverter.ToUInt64(Ymm2, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm2 == null)
                    Ymm2 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm2[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM3.
        /// </summary>
        /// <value>The XMM3.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm3
        {
            get => Ymm3?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm3 == null)
                    Ymm3 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm3[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM3H.
        /// </summary>
        /// <value>The XMM3H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm3h
        {
            get => Ymm3 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm3, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm3 == null)
                    Ymm3 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm3[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM3L.
        /// </summary>
        /// <value>The XMM3L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm3l
        {
            get => Ymm3 != null ? (ulong?) BitConverter.ToUInt64(Ymm3, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm3 == null)
                    Ymm3 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm3[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM4.
        /// </summary>
        /// <value>The XMM4.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm4
        {
            get => Ymm4?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm4 == null)
                    Ymm4 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm4[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM4H.
        /// </summary>
        /// <value>The XMM4H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm4h
        {
            get => Ymm4 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm4, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm4 == null)
                    Ymm4 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm4[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM4L.
        /// </summary>
        /// <value>The XMM4L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm4l
        {
            get => Ymm4 != null ? (ulong?) BitConverter.ToUInt64(Ymm4, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm4 == null)
                    Ymm4 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm4[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM5.
        /// </summary>
        /// <value>The XMM5.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm5
        {
            get => Ymm5?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm5 == null)
                    Ymm5 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm5[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM5H.
        /// </summary>
        /// <value>The XMM5H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm5h
        {
            get => Ymm5 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm5, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm5 == null)
                    Ymm5 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm5[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM5L.
        /// </summary>
        /// <value>The XMM5L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm5l
        {
            get => Ymm5 != null ? (ulong?) BitConverter.ToUInt64(Ymm5, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm5 == null)
                    Ymm5 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm5[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM6.
        /// </summary>
        /// <value>The XMM6.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm6
        {
            get => Ymm6?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm6 == null)
                    Ymm6 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm6[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM6H.
        /// </summary>
        /// <value>The XMM6H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm6h
        {
            get => Ymm6 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm6, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm6 == null)
                    Ymm6 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm6[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM6L.
        /// </summary>
        /// <value>The XMM6L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm6l
        {
            get => Ymm6 != null ? (ulong?) BitConverter.ToUInt64(Ymm6, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm6 == null)
                    Ymm6 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm6[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM7.
        /// </summary>
        /// <value>The XMM7.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm7
        {
            get => Ymm7?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm7 == null)
                    Ymm7 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm7[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM7H.
        /// </summary>
        /// <value>The XMM7H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm7h
        {
            get => Ymm7 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm7, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm7 == null)
                    Ymm7 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm7[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM7L.
        /// </summary>
        /// <value>The XMM7L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm7l
        {
            get => Ymm7 != null ? (ulong?) BitConverter.ToUInt64(Ymm7, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm7 == null)
                    Ymm7 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm7[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM8.
        /// </summary>
        /// <value>The XMM8.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm8
        {
            get => Ymm8?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm8 == null)
                    Ymm8 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm8[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM8H.
        /// </summary>
        /// <value>The XMM8H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm8h
        {
            get => Ymm8 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm8, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm8 == null)
                    Ymm8 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm8[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM8L.
        /// </summary>
        /// <value>The XMM8L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm8l
        {
            get => Ymm8 != null ? (ulong?) BitConverter.ToUInt64(Ymm8, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm8 == null)
                    Ymm8 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm8[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM9.
        /// </summary>
        /// <value>The XMM9.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Xmm9
        {
            get => Ymm9?.Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (Ymm9 == null)
                    Ymm9 = new byte[32];
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 16");
                for (var i = 0; i < 16; i++)
                    Ymm9[i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM9H.
        /// </summary>
        /// <value>The XMM9H.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm9h
        {
            get => Ymm9 == null ? null : (ulong?) BitConverter.ToUInt64(Ymm9, 8);
            set
            {
                if (value == null)
                    return;
                if (Ymm9 == null)
                    Ymm9 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++) Ymm9[8 + i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the XMM9L.
        /// </summary>
        /// <value>The XMM9L.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public ulong? Xmm9l
        {
            get => Ymm9 != null ? (ulong?) BitConverter.ToUInt64(Ymm9, 0) : null;
            set
            {
                if (value == null)
                    return;
                if (Ymm9 == null)
                    Ymm9 = new byte[32];

                var bytes = BitConverter.GetBytes(value.Value);
                for (var i = 0; i < 8; i++)
                    Ymm9[i] = bytes[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm0.
        /// </summary>
        /// <value>The ymm0.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm0
        {
            get => _ymm0;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm0 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm0h.
        /// </summary>
        /// <value>The ymm0h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm0h
        {
            get => Ymm0?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if(value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm0h requires 16");
                if (Ymm0 == null)
                    Ymm0 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm0[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm0l.
        /// </summary>
        /// <value>The ymm0l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm0l
        {
            get => Xmm0;
            set => Xmm0 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm1.
        /// </summary>
        /// <value>The ymm1.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm1
        {
            get => _ymm1;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm1 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm10.
        /// </summary>
        /// <value>The ymm10.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm10
        {
            get => _ymm10;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm10 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm10h.
        /// </summary>
        /// <value>The ymm10h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm10h
        {
            get => Ymm10?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm10h requires 16");
                if (Ymm10 == null)
                    Ymm10 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm10[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm10l.
        /// </summary>
        /// <value>The ymm10l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm10l
        {
            get => Xmm10;
            set => Xmm10 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm11.
        /// </summary>
        /// <value>The ymm11.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm11
        {
            get => _ymm11;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm11 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm11h.
        /// </summary>
        /// <value>The ymm11h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm11h
        {
            get => Ymm11?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm11h requires 16");
                if (Ymm11 == null)
                    Ymm11 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm11[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm11l.
        /// </summary>
        /// <value>The ymm11l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm11l
        {
            get => Xmm11;
            set => Xmm11 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm12.
        /// </summary>
        /// <value>The ymm12.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm12
        {
            get => _ymm12;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm12 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm12h.
        /// </summary>
        /// <value>The ymm12h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm12h
        {
            get => Ymm12?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm12h requires 16");
                if (Ymm12 == null)
                    Ymm12 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm12[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm12l.
        /// </summary>
        /// <value>The ymm12l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm12l
        {
            get => Xmm12;
            set => Xmm12 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm13.
        /// </summary>
        /// <value>The ymm13.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm13
        {
            get => _ymm13;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm13 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm13h.
        /// </summary>
        /// <value>The ymm13h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm13h
        {
            get => Ymm13?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm13h requires 16");
                if (Ymm13 == null)
                    Ymm13 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm13[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm13l.
        /// </summary>
        /// <value>The ymm13l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm13l
        {
            get => Xmm13;
            set => Xmm13 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm14.
        /// </summary>
        /// <value>The ymm14.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm14
        {
            get => _ymm14;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm14 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm14h.
        /// </summary>
        /// <value>The ymm14h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm14h
        {
            get => Ymm14?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm14h requires 16");
                if (Ymm14 == null)
                    Ymm14 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm14[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm14l.
        /// </summary>
        /// <value>The ymm14l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm14l
        {
            get => Xmm14;
            set => Xmm14 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm15.
        /// </summary>
        /// <value>The ymm15.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm15
        {
            get => _ymm15;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm15 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm15h.
        /// </summary>
        /// <value>The ymm15h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm15h
        {
            get => Ymm15?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm15h requires 16");
                if (Ymm15 == null)
                    Ymm15 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm15[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm15l.
        /// </summary>
        /// <value>The ymm15l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm15l
        {
            get => Xmm15;
            set => Xmm15 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm1h.
        /// </summary>
        /// <value>The ymm1h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm1h
        {
            get => Ymm1?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm1h requires 16");
                if (Ymm1 == null)
                    Ymm1 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm1[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm1l.
        /// </summary>
        /// <value>The ymm1l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm1l
        {
            get => Xmm1;
            set => Xmm1 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm2.
        /// </summary>
        /// <value>The ymm2.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm2
        {
            get => _ymm2;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm2 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm2h.
        /// </summary>
        /// <value>The ymm2h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm2h
        {
            get => Ymm2?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm2h requires 16");
                if (Ymm2 == null)
                    Ymm2 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm2[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm2l.
        /// </summary>
        /// <value>The ymm2l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm2l
        {
            get => Xmm2;
            set => Xmm2 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm3.
        /// </summary>
        /// <value>The ymm3.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm3
        {
            get => _ymm3;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm3 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm3h.
        /// </summary>
        /// <value>The ymm3h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm3h
        {
            get => Ymm3?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm3h requires 16");
                if (Ymm3 == null)
                    Ymm3 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm3[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm3l.
        /// </summary>
        /// <value>The ymm3l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm3l
        {
            get => Xmm3;
            set => Xmm3 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm4.
        /// </summary>
        /// <value>The ymm4.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm4
        {
            get => _ymm4;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm4 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm4h.
        /// </summary>
        /// <value>The ymm4h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm4h
        {
            get => Ymm4?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm4h requires 16");
                if (Ymm4 == null)
                    Ymm4 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm4[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm4l.
        /// </summary>
        /// <value>The ymm4l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm4l
        {
            get => Xmm4;
            set => Xmm4 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm5.
        /// </summary>
        /// <value>The ymm5.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm5
        {
            get => _ymm5;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm5 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm5h.
        /// </summary>
        /// <value>The ymm5h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm5h
        {
            get => Ymm5?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm5h requires 16");
                if (Ymm5 == null)
                    Ymm5 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm5[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm5l.
        /// </summary>
        /// <value>The ymm5l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm5l
        {
            get => Xmm5;
            set => Xmm5 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm6.
        /// </summary>
        /// <value>The ymm6.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm6
        {
            get => _ymm6;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm6 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm6h.
        /// </summary>
        /// <value>The ymm6h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm6h
        {
            get => Ymm6?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm6h requires 16");
                if (Ymm6 == null)
                    Ymm6 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm6[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm6l.
        /// </summary>
        /// <value>The ymm6l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm6l
        {
            get => Xmm6;
            set => Xmm6 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm7.
        /// </summary>
        /// <value>The ymm7.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm7
        {
            get => _ymm7;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm7 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm7h.
        /// </summary>
        /// <value>The ymm7h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm7h
        {
            get => Ymm7?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm7h requires 16");
                if (Ymm7 == null)
                    Ymm7 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm7[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm7l.
        /// </summary>
        /// <value>The ymm7l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm7l
        {
            get => Xmm7;
            set => Xmm7 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm8.
        /// </summary>
        /// <value>The ymm8.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm8
        {
            get => _ymm8;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm8 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm8h.
        /// </summary>
        /// <value>The ymm8h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm8h
        {
            get => Ymm8?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm8h requires 16");
                if (Ymm8 == null)
                    Ymm8 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm8[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm8l.
        /// </summary>
        /// <value>The ymm8l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm8l
        {
            get => Xmm8;
            set => Xmm8 = value;
        }

        /// <summary>
        ///     Gets or sets the ymm9.
        /// </summary>
        /// <value>The ymm9.</value>
        /// <exception cref="ArgumentOutOfRangeException">value</exception>
        public byte[] Ymm9
        {
            get => _ymm9;
            set
            {
                if (value != null && value.Length != 32)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} has {value.Length} bytes but must have exactly 32");
                _ymm9 = value;
            }
        }

        /// <summary>
        ///     Gets or sets the ymm9h.
        /// </summary>
        /// <value>The ymm9h.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm9h
        {
            get => Ymm9?.Skip(16).Take(16).ToArray();
            set
            {
                if (value == null)
                    return;
                if (value.Length != 16)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} has {value.Length} bytes, but Ymm9h requires 16");
                if (Ymm9 == null)
                    Ymm9 = new byte[32];

                for (var i = 0; i < 16; i++)
                    Ymm9[16 + i] = value[i];
            }
        }

        /// <summary>
        ///     Gets or sets the ymm9l.
        /// </summary>
        /// <value>The ymm9l.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public byte[] Ymm9l
        {
            get => Xmm9;
            set => Xmm9 = value;
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="RegisterSet" /> is zf.
        /// </summary>
        /// <value><c>null</c> if [zf] contains no value, <c>true</c> if [zf]; otherwise, <c>false</c>.</value>
        [JsonIgnore]
        [XmlIgnore]
        [SoapIgnore]
        public bool? Zf
        {
            get => Efl.HasValue ? (bool?) ((Efl & 0x0040) > 0) : null;
            set
            {
                if (!value.HasValue) return;
                if (!Efl.HasValue)
                    Efl = 0;
                uint mask = 0x0040;
                if (value.Value)
                    Efl = Efl |= mask;
                else
                    Efl = Efl &= ~mask;
            }
        }
    }
}


/*
64 bit
0:rax
1:rcx
2:rdx
3:rbx
4:rsp
5:rbp
6:rsi
7:rdi
8:r8
9:r9
10:r10
11:r11
12:r12
13:r13
14:r14
15:r15
16:rip
17:efl
18:cs
19:ds
20:es
21:fs
22:gs
23:ss
24:dr0
25:dr1
26:dr2
27:dr3
28:dr6
29:dr7
30:fpcw
31:fpsw
32:fptw
33:st0
34:st1
35:st2
36:st3
37:st4
38:st5
39:st6
40:st7
41:mm0
42:mm1
43:mm2
44:mm3
45:mm4
46:mm5
47:mm6
48:mm7
49:mxcsr
50:xmm0
51:xmm1
52:xmm2
53:xmm3
54:xmm4
55:xmm5
56:xmm6
57:xmm7
58:xmm8
59:xmm9
60:xmm10
61:xmm11
62:xmm12
63:xmm13
64:xmm14
65:xmm15
66:xmm0/0
67:xmm0/1
68:xmm0/2
69:xmm0/3
70:xmm1/0
71:xmm1/1
72:xmm1/2
73:xmm1/3
74:xmm2/0
75:xmm2/1
76:xmm2/2
77:xmm2/3
78:xmm3/0
79:xmm3/1
80:xmm3/2
81:xmm3/3
82:xmm4/0
83:xmm4/1
84:xmm4/2
85:xmm4/3
86:xmm5/0
87:xmm5/1
88:xmm5/2
89:xmm5/3
90:xmm6/0
91:xmm6/1
92:xmm6/2
93:xmm6/3
94:xmm7/0
95:xmm7/1
96:xmm7/2
97:xmm7/3
98:xmm8/0
99:xmm8/1
100:xmm8/2
101:xmm8/3
102:xmm9/0
103:xmm9/1
104:xmm9/2
105:xmm9/3
106:xmm10/0
107:xmm10/1
108:xmm10/2
109:xmm10/3
110:xmm11/0
111:xmm11/1
112:xmm11/2
113:xmm11/3
114:xmm12/0
115:xmm12/1
116:xmm12/2
117:xmm12/3
118:xmm13/0
119:xmm13/1
120:xmm13/2
121:xmm13/3
122:xmm14/0
123:xmm14/1
124:xmm14/2
125:xmm14/3
126:xmm15/0
127:xmm15/1
128:xmm15/2
129:xmm15/3
130:xmm0l
131:xmm1l
132:xmm2l
133:xmm3l
134:xmm4l
135:xmm5l
136:xmm6l
137:xmm7l
138:xmm8l
139:xmm9l
140:xmm10l
141:xmm11l
142:xmm12l
143:xmm13l
144:xmm14l
145:xmm15l
146:xmm0h
147:xmm1h
148:xmm2h
149:xmm3h
150:xmm4h
151:xmm5h
152:xmm6h
153:xmm7h
154:xmm8h
155:xmm9h
156:xmm10h
157:xmm11h
158:xmm12h
159:xmm13h
160:xmm14h
161:xmm15h
162:ymm0
163:ymm1
164:ymm2
165:ymm3
166:ymm4
167:ymm5
168:ymm6
169:ymm7
170:ymm8
171:ymm9
172:ymm10
173:ymm11
174:ymm12
175:ymm13
176:ymm14
177:ymm15
178:ymm0/0
179:ymm0/1
180:ymm0/2
181:ymm0/3
182:ymm1/0
183:ymm1/1
184:ymm1/2
185:ymm1/3
186:ymm2/0
187:ymm2/1
188:ymm2/2
189:ymm2/3
190:ymm3/0
191:ymm3/1
192:ymm3/2
193:ymm3/3
194:ymm4/0
195:ymm4/1
196:ymm4/2
197:ymm4/3
198:ymm5/0
199:ymm5/1
200:ymm5/2
201:ymm5/3
202:ymm6/0
203:ymm6/1
204:ymm6/2
205:ymm6/3
206:ymm7/0
207:ymm7/1
208:ymm7/2
209:ymm7/3
210:ymm8/0
211:ymm8/1
212:ymm8/2
213:ymm8/3
214:ymm9/0
215:ymm9/1
216:ymm9/2
217:ymm9/3
218:ymm10/0
219:ymm10/1
220:ymm10/2
221:ymm10/3
222:ymm11/0
223:ymm11/1
224:ymm11/2
225:ymm11/3
226:ymm12/0
227:ymm12/1
228:ymm12/2
229:ymm12/3
230:ymm13/0
231:ymm13/1
232:ymm13/2
233:ymm13/3
234:ymm14/0
235:ymm14/1
236:ymm14/2
237:ymm14/3
238:ymm15/0
239:ymm15/1
240:ymm15/2
241:ymm15/3
242:ymm0l
243:ymm1l
244:ymm2l
245:ymm3l
246:ymm4l
247:ymm5l
248:ymm6l
249:ymm7l
250:ymm8l
251:ymm9l
252:ymm10l
253:ymm11l
254:ymm12l
255:ymm13l
256:ymm14l
257:ymm15l
258:ymm0h
259:ymm1h
260:ymm2h
261:ymm3h
262:ymm4h
263:ymm5h
264:ymm6h
265:ymm7h
266:ymm8h
267:ymm9h
268:ymm10h
269:ymm11h
270:ymm12h
271:ymm13h
272:ymm14h
273:ymm15h
274:exfrom
275:exto
276:brfrom
277:brto
278:eax
279:ecx
280:edx
281:ebx
282:esp
283:ebp
284:esi
285:edi
286:r8d
287:r9d
288:r10d
289:r11d
290:r12d
291:r13d
292:r14d
293:r15d
294:eip
295:ax
296:cx
297:dx
298:bx
299:sp
300:bp
301:si
302:di
303:r8w
304:r9w
305:r10w
306:r11w
307:r12w
308:r13w
309:r14w
310:r15w
311:ip
312:fl
313:al
314:cl
315:dl
316:bl
317:spl
318:bpl
319:sil
320:dil
321:r8b
322:r9b
323:r10b
324:r11b
325:r12b
326:r13b
327:r14b
328:r15b
329:ah
330:ch
331:dh
332:bh
333:iopl
334:of
335:df
336:if
337:tf
338:sf
339:zf
340:af
341:pf
342:cf
343:vip
344:vif

x86
0:gs
1:fs
2:es
3:ds
4:edi
5:esi
6:ebx
7:edx
8:ecx
9:eax
10:ebp
11:eip
12:cs
13:efl
14:esp
15:ss
16:dr0
17:dr1
18:dr2
19:dr3
20:dr6
21:dr7
22:di
23:si
24:bx
25:dx
26:cx
27:ax
28:bp
29:ip
30:fl
31:sp
32:bl
33:dl
34:cl
35:al
36:bh
37:dh
38:ch
39:ah
40:fpcw
41:fpsw
42:fptw
43:fopcode
44:fpip
45:fpipsel
46:fpdp
47:fpdpsel
48:st0
49:st1
50:st2
51:st3
52:st4
53:st5
54:st6
55:st7
56:mm0
57:mm1
58:mm2
59:mm3
60:mm4
61:mm5
62:mm6
63:mm7
64:mxcsr
65:xmm0
66:xmm1
67:xmm2
68:xmm3
69:xmm4
70:xmm5
71:xmm6
72:xmm7
73:iopl
74:of
75:df
76:if
77:tf
78:sf
79:zf
80:af
81:pf
82:cf
83:vip
84:vif
85:xmm0l
86:xmm1l
87:xmm2l
88:xmm3l
89:xmm4l
90:xmm5l
91:xmm6l
92:xmm7l
93:xmm0h
94:xmm1h
95:xmm2h
96:xmm3h
97:xmm4h
98:xmm5h
99:xmm6h
100:xmm7h
101:xmm0/0
102:xmm0/1
103:xmm0/2
104:xmm0/3
105:xmm1/0
106:xmm1/1
107:xmm1/2
108:xmm1/3
109:xmm2/0
110:xmm2/1
111:xmm2/2
112:xmm2/3
113:xmm3/0
114:xmm3/1
115:xmm3/2
116:xmm3/3
117:xmm4/0
118:xmm4/1
119:xmm4/2
120:xmm4/3
121:xmm5/0
122:xmm5/1
123:xmm5/2
124:xmm5/3
125:xmm6/0
126:xmm6/1
127:xmm6/2
128:xmm6/3
129:xmm7/0
130:xmm7/1
131:xmm7/2
132:xmm7/3
133:ymm0
134:ymm1
135:ymm2
136:ymm3
137:ymm4
138:ymm5
139:ymm6
140:ymm7
141:ymm0l
142:ymm1l
143:ymm2l
144:ymm3l
145:ymm4l
146:ymm5l
147:ymm6l
148:ymm7l
149:ymm0h
150:ymm1h
151:ymm2h
152:ymm3h
153:ymm4h
154:ymm5h
155:ymm6h
156:ymm7h
157:ymm0/0
158:ymm0/1
159:ymm0/2
160:ymm0/3
161:ymm1/0
162:ymm1/1
163:ymm1/2
164:ymm1/3
165:ymm2/0
166:ymm2/1
167:ymm2/2
168:ymm2/3
169:ymm3/0
170:ymm3/1
171:ymm3/2
172:ymm3/3
173:ymm4/0
174:ymm4/1
175:ymm4/2
176:ymm4/3
177:ymm5/0
178:ymm5/1
179:ymm5/2
180:ymm5/3
181:ymm6/0
182:ymm6/1
183:ymm6/2
184:ymm6/3
185:ymm7/0
186:ymm7/1
187:ymm7/2
188:ymm7/3
*/
