﻿// ***********************************************************************
// Assembly         : McFly.Server.Data.SqlServer
// Author           : @tysmithnet
// Created          : 04-01-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-27-2018
// ***********************************************************************
// <copyright file="TraceInfoEntity.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McFly.Server.Data.SqlServer
{
    /// <summary>
    ///     Entity representing the trace meta data
    /// </summary>
    [Table("trace_info")]
    public class TraceInfoEntity
    {
        /// <summary>
        ///     Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     Gets or sets the end position hi.
        /// </summary>
        /// <value>The end position hi.</value>
        [Column("end_pos_hi")]
        public int EndPosHi { get; set; }

        /// <summary>
        ///     Gets or sets the end position lo.
        /// </summary>
        /// <value>The end position lo.</value>
        [Column("end_pos_lo")]
        public int EndPosLo { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this trace is a 32 bit trace.
        /// </summary>
        /// <value><c>true</c> if this is a 32 bit trace; otherwise, <c>false</c>.</value>
        [Column("is_x86")]
        public bool Is32Bit { get; set; }

        /// <summary>
        ///     Gets or sets the lock. This is to ensure there is only ever 1 entity.
        /// </summary>
        /// <value>The lock.</value>
        [Column("lock")]
        [Range(1, 1)]
        [Key]
        public int Lock { get; set; }

        /// <summary>
        ///     Gets or sets the start position hi.
        /// </summary>
        /// <value>The start position hi.</value>
        [Column("start_pos_hi")]
        public int StartPosHi { get; set; }

        /// <summary>
        ///     Gets or sets the start position lo.
        /// </summary>
        /// <value>The start position lo.</value>
        [Column("start_pos_lo")]
        public int StartPosLo { get; set; }
    }
}