﻿// ***********************************************************************
// Assembly         : McFly.Server.Data
// Author           : @tsmithnet
// Created          : 02-20-2018
//
// Last Modified By : @tsmithnet
// Last Modified On : 04-01-2018
// ***********************************************************************
// <copyright file="FrameAccess.cs" company="McFly.Server.Data">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Common.Logging;
using McFly.Core;

namespace McFly.Server.Data.SqlServer
{
    /// <summary>
    ///     Represents the data access logic for the frame domain
    /// </summary>
    /// <seealso cref="McFly.Server.Data.SqlServer.DataAccess" />
    /// <seealso cref="DataAccess" />
    /// <seealso cref="McFly.Server.Data.IFrameAccess" />
    [Export(typeof(IFrameAccess))]
    [Export(typeof(FrameAccess))]
    internal class FrameAccess : DataAccess, IFrameAccess
    {
        /// <summary>
        ///     The log
        /// </summary>
        private ILog Log = LogManager.GetLogger<FrameAccess>(); // todo: fix logging in mcfly

        /// <summary>
        ///     Gets or sets the context factory.
        /// </summary>
        /// <value>The context factory.</value>
        [Import]
        protected internal IContextFactory ContextFactory { get; set; }

        /// <summary>
        ///     Upserts the frame.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="frames">The frames.</param>
        public void UpsertFrames(string projectName, IEnumerable<Frame> frames)
        {
            frames = frames.ToList();
            using (var context = ContextFactory.GetContext(projectName))
            {
                foreach (var frame in frames)
                {
                    var source = frame.ToFrameEntity();
                    var target = context.FrameEntities.FirstOrDefault(x =>
                        x.PosHi == source.PosHi && x.PosLo == source.PosLo && x.ThreadId == source.ThreadId);
                    if (target != null)
                        CopyValues(source, target);
                    else
                        context.FrameEntities.Add(source);
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        ///     Gets the frame.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="position">The position.</param>
        /// <param name="threadId">The thread identifier.</param>
        /// <returns>Frame.</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Frame GetFrame(string projectName, Position position, int threadId)
        {
            using (var context = ContextFactory.GetContext(projectName))
            {
                var first = context.FrameEntities.FirstOrDefault(x =>
                    x.PosHi == position.High && x.PosLo == position.Low && x.ThreadId == threadId);
                if (first == null)
                    throw new IndexOutOfRangeException(
                        $"Count not find a frame with position: {position} and threadid: {threadId}");
                return first.ToFrame();
            }
        }

        /// <summary>
        ///     Copies the values.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="target">The target.</param>
        private static void CopyValues(FrameEntity source, FrameEntity target)
        {
            if (source.Rax.HasValue)
                target.Rax = source.Rax;

            if (source.Rbx.HasValue)
                target.Rbx = source.Rbx;

            if (source.Rcx.HasValue)
                target.Rcx = source.Rcx;

            if (source.Rdx.HasValue)
                target.Rdx = source.Rdx;

            if (source.Address.HasValue)
                target.Address = source.Address;

            if (source.DisassemblyNote != null)
                target.DisassemblyNote = source.DisassemblyNote;

            if (source.OpCode != null)
                target.OpCode = source.OpCode;

            if (source.OpCodeMnemonic != null)
                target.OpCodeMnemonic = source.DisassemblyNote;

            if (source.StackFrames != null)
                foreach (var sourceStackFrame in source.StackFrames)
                {
                    var targetStackFrame =
                        target.StackFrames?.FirstOrDefault(x => x.StackPointer == sourceStackFrame.StackPointer);
                    if (targetStackFrame != null)
                    {
                        // copy source values to target
                        if (sourceStackFrame.ReturnAddress.HasValue)
                            targetStackFrame.ReturnAddress = sourceStackFrame.ReturnAddress;
                        if (sourceStackFrame.ModuleName != null)
                            targetStackFrame.ModuleName = sourceStackFrame.ModuleName;
                        if (sourceStackFrame.Function != null)
                            targetStackFrame.Function = sourceStackFrame.Function;
                        if (sourceStackFrame.Offset.HasValue)
                            targetStackFrame.Offset = sourceStackFrame.Offset;
                    }
                    else
                    {
                        target.StackFrames.Add(sourceStackFrame);
                    }
                }
        }
    }
}