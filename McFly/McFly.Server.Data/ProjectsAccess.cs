﻿// ***********************************************************************
// Assembly         : McFly.Server.Data
// Author           : @tsmithnet
// Created          : 02-20-2018
//
// Last Modified By : @tsmithnet
// Last Modified On : 03-03-2018
// ***********************************************************************
// <copyright file="ProjectsAccess.cs" company="McFly.Server.Data">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using McFly.Core;
using Microsoft.Extensions.Logging;

namespace McFly.Server.Data
{
    /// <summary>
    ///     Class ProjectsAccess.
    /// </summary>
    /// <seealso cref="McFly.Server.Data.DataAccess" />
    /// <seealso cref="McFly.Server.Data.IProjectsAccess" />
    public class ProjectsAccess : DataAccess, IProjectsAccess
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectsAccess" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <exception cref="ArgumentNullException">logger</exception>
        public ProjectsAccess(ILogger<ProjectsAccess> logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        ///     Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        private ILogger<ProjectsAccess> Logger { get; }

        /// <summary>
        ///     Gets the databases.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public IEnumerable<string> GetDatabases()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText =
                    "SELECT NAME FROM sys.databases WHERE NAME NOT IN('master', 'tempdb', 'model', 'msdb')";
                var databases = new List<string>();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    databases.Add(reader.GetFieldValue<string>(0));
                return databases;
            }
        }

        /// <summary>
        ///     Creates the project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        public void CreateProject(string projectName, Position start, Position end)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var createDbCommand = conn.CreateCommand())
            {
                conn.Open();
                createDbCommand.CommandText = $"CREATE DATABASE {projectName}";
                try
                {
                    createDbCommand.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Logger.LogError($"Unable to create Database {projectName}: {e.Message}");
                    throw;
                }
            }

            var sqlBuilder = new SqlConnectionStringBuilder(ConnectionString) {InitialCatalog = projectName};
            using (var conn = new SqlConnection(sqlBuilder.ToString()))
            {
                try
                {
                    conn.Open();
                    string dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string fileName = Path.Combine(dirName, "create.sql");
                    string initScript = null;
                    using (var stream = File.OpenRead(fileName))
                    using (var reader = new StreamReader(stream))
                    {
                        initScript = reader.ReadToEnd();
                    }

                    initScript = Regex.Replace(initScript, @":setvar DatabaseName ""McFly\.SqlServer""",
                        $@":setvar DatabaseName ""{projectName}""");

                    var commandStrings = Regex.Split(initScript, @"^\s*GO\s*$",
                        RegexOptions.Multiline | RegexOptions.IgnoreCase);

                    foreach (var commandString in commandStrings)
                    {
                        if (string.IsNullOrWhiteSpace(commandString))
                            continue;
                        using (var command = conn.CreateCommand())
                        {
                            command.CommandText = commandString;
                            command.ExecuteNonQuery();
                        }
                    }

                    using (var infoCommand = conn.CreateCommand())
                    {
                        infoCommand.CommandText =
                            $"INSERT INTO trace_info (start_pos_hi, start_pos_lo, end_pos_hi, end_pos_lo) VALUES ({start.High}, {start.Low}, {end.High}, {end.Low})";
                        infoCommand.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    using (var singleUser = conn.CreateCommand())
                    using (var deleteCommand = conn.CreateCommand())
                    {
                        singleUser.CommandText =
                            $"ALTER DATABASE [{projectName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        singleUser.ExecuteNonQuery();

                        deleteCommand.CommandText = $"DROP DATABASE {projectName}"; // todo: close connections
                        deleteCommand.ExecuteNonQuery();
                        throw;
                    }
                }
            }
        }
    }
}