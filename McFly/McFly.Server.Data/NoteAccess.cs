﻿// ***********************************************************************
// Assembly         : McFly.Server.Data
// Author           : @tsmithnet
// Created          : 02-20-2018
//
// Last Modified By : @tsmithnet
// Last Modified On : 03-12-2018
// ***********************************************************************
// <copyright file="NoteAccess.cs" company="McFly.Server.Data">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using McFly.Core;

namespace McFly.Server.Data
{
    /// <summary>
    ///     INoteAccess implementation that uses SQL Server
    /// </summary>
    /// <seealso cref="McFly.Server.Data.DataAccess" />
    /// <seealso cref="McFly.Server.Data.INoteAccess" />
    public class NoteAccess : DataAccess, INoteAccess
    {
        /// <summary>
        ///     Adds a note to a thread position
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="threadId">The thread identifier.</param>
        /// <param name="text">The text.</param>
        public void AddNote(string projectName, Position position, int? threadId, string text)
        {
            ExecuteStoredProcedureNonQuery(projectName, "pr_add_note", CreateParameters(position, threadId, text));
        }

        private IEnumerable<SqlParameter> CreateParameters(Position position, int? threadId, string text)
        {
            var posHi = new SqlParameter("@pos_hi", SqlDbType.Int) {Value = position.High};
            var posLo = new SqlParameter("@pos_lo", SqlDbType.Int) {Value = position.Low};
            var tid = new SqlParameter("@thread_id", SqlDbType.Int) {Value = threadId};
            var txt = new SqlParameter(@"text", SqlDbType.Text) {Value = text};

            return new[] {posHi, posLo, tid, txt};
        }
    }
}