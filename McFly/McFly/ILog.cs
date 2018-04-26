﻿// ***********************************************************************
// Assembly         : mcfly
// Author           : @tysmithnet
// Created          : 03-04-2018
//
// Last Modified By : @tysmithnet
// Last Modified On : 04-26-2018
// ***********************************************************************
// <copyright file="ILog.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace McFly
{
    /// <summary>
    ///     Clientside logging interface
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="McFly.IInjectable" />
    public interface ILog : IDisposable, IInjectable
    {
        /// <summary>
        ///     Logs a debug message
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>
        ///     Logs an error message
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        ///     Logs an exception to the error log
        /// </summary>
        /// <param name="exception">The exception.</param>
        void Error(Exception exception);

        /// <summary>
        ///     Logs a fatal messasge
        /// </summary>
        /// <param name="message">The message.</param>
        void Fatal(string message);

        /// <summary>
        ///     Logs a fatal exception
        /// </summary>
        /// <param name="exception">The exception.</param>
        void Fatal(Exception exception);

        /// <summary>
        ///     Logs an informational message
        /// </summary>
        /// <param name="messasge">The messasge.</param>
        void Info(string messasge);

        /// <summary>
        ///     Logs a verbose message
        /// </summary>
        /// <param name="message">The message.</param>
        void Verbose(string message);
    }
}