﻿// ***********************************************************************
// Assembly         : mcfly
// Author           : master
// Created          : 03-06-2018
//
// Last Modified By : master
// Last Modified On : 03-24-2018
// ***********************************************************************
// <copyright file="SettingsMethod.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using CommandLine;
using Newtonsoft.Json;

namespace McFly
{
    /// <summary>
    ///     Class SettingsMethod.
    /// </summary>
    /// <seealso cref="McFly.IMcFlyMethod" />
    [Export(typeof(IMcFlyMethod))]
    public class SettingsMethod : IMcFlyMethod
    {
        /// <summary>
        ///     Gets or sets all settings.
        /// </summary>
        /// <value>All settings.</value>
        [ImportMany]
        public ISettings[] AllSettings { get; set; }

        /// <summary>
        ///     Gets or sets the debug eng proxy.
        /// </summary>
        /// <value>The debug eng proxy.</value>
        [Import]
        public IDebugEngineProxy DebugEngineProxy { get; set; }

        public HelpInfo HelpInfo { get; } = new HelpInfoBuilder()
            .SetName("settings")
            .SetDescription("Manage application settings")
            .AddSubcommand(new HelpInfoBuilder()
                .SetName("list")
                .SetDescription("List the current settings and their values")
                .Build())
            .AddSubcommand(new HelpInfoBuilder()
                .SetName("reload")
                .SetDescription("Reload the settings from the settings file")
                .Build())
            .Build();

        /// <summary>
        ///     Processes the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>Task.</returns>
        [ExcludeFromCodeCoverage]
        public void Process(string[] args)
        {
            Parser.Default.ParseArguments<ReloadOptions, ListOptions>(args)
                .WithParsed<ReloadOptions>(r => { McFlyExtension.PopulateSettings(); })
                .WithParsed<ListOptions>(l =>
                {
                    foreach (var settings in AllSettings)
                    {
                        DebugEngineProxy.WriteLine(settings.GetType().FullName);
                        DebugEngineProxy.WriteLine(JsonConvert.SerializeObject(settings, Formatting.Indented));
                    }
                });
        }
    }

    /// <summary>
    ///     Class ReloadOptions.
    /// </summary>
    [Verb("reload", HelpText = "Reload the settings from the settings file")]
    public class ReloadOptions
    {
    }

    /// <summary>
    ///     Class ListOptions.
    /// </summary>
    [Verb("list", HelpText = "List the current settings and their values")]
    public class ListOptions
    {
    }
}