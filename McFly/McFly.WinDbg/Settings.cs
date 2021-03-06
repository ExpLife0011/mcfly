﻿// ***********************************************************************
// Assembly         : mcfly
// Author           : @tysmithnet
// Created          : 02-25-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-03-2018
// ***********************************************************************
// <copyright file="Settings.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel.Composition;

namespace McFly.WinDbg
{
    /// <summary>
    ///     Class Settings.
    /// </summary>
    /// <seealso cref="ISettings" />
    [Export(typeof(ISettings))]
    [Export(typeof(Settings))]
    public class Settings : ISettings
    {
        /// <summary>
        ///     Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        public string ConnectionString { get; set; }

        /// <summary>
        ///     Gets or sets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        public string ProjectName { get; set; }

        /// <summary>
        ///     Gets or sets the launcher path.
        /// </summary>
        /// <value>The launcher path.</value>
        public string ServerExePath { get; set; }

        /// <summary>
        ///     Gets or sets the server URL.
        /// </summary>
        /// <value>The server URL.</value>
        public string ServerUrl { get; set; }
    }
}