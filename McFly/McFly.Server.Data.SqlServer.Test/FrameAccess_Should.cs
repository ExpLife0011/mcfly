﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using McFly.Core;
using McFly.Server.Data.Search;
using Xunit;

namespace McFly.Server.Data.SqlServer.Test
{
    public class FrameAccess_Should
    {
        [Fact]
        public void Find_Matching_Frames_When_Searched_For()
        {
            var frameAccess = new FrameAccess();
            var builder = new ContextFactoryBuilder();
            builder.WithFrame(new FrameEntity
            {
                PosHi = 0,
                PosLo = 0,
                ThreadId = 1,
                Rax = ((ulong)1).ToByteArray()
            }).WithFrame(new FrameEntity
            {
                PosHi = 0,
                PosLo = 0,
                ThreadId = 2,
                Rax = ((ulong)2).ToByteArray()
            });
            frameAccess.ContextFactory = builder.Build();

            var results = frameAccess.Search("", new RegisterEqualsCriterion(Register.Rax, ((ulong)1).ToByteArray()));
            results.Single().RegisterSet.Rax.Should().Be(1);
        }

        [Fact]
        public void Get_The_Correct_Frame_If_One_Exists()
        {
            var access = new FrameAccess();
            var builder = new ContextFactoryBuilder();
            var frame = new FrameEntity
            {
                PosHi = 0,
                PosLo = 0,
                ThreadId = 1
            };
            builder.WithFrame(frame);
            access.ContextFactory = builder.Build();
            access.GetFrame("anyproject", new Position(0, 0), 1).Should().Be(frame.ToFrame());
        }

        [Fact]
        public void Throw_If_Frame_Cant_Be_Found()
        {
            var access = new FrameAccess();
            var builder = new ContextFactoryBuilder();
            var frame = new FrameEntity
            {
                PosHi = 0,
                PosLo = 0,
                ThreadId = 1
            };
            builder.WithFrame(frame);
            access.ContextFactory = builder.Build();
            Action throws = () => access.GetFrame("test", new Position(1, 0), 1);

            throws.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Update_Existing_Frames_And_Insert_New_When_Upserting()
        {
            var access = new FrameAccess();
            var builder = new ContextFactoryBuilder();
            builder.WithFrame(new FrameEntity
            {
                PosHi = 0,
                PosLo = 0,
                ThreadId = 1,
                Rax = 1.ToByteArray(),
                Rbx = 2.ToByteArray(),
                Rcx = 3.ToByteArray(),
                Rdx = 4.ToByteArray(),
                DisassemblyNote = "r9,r8",
                Rip = 90.ToByteArray(),
                OpCode = new byte[] {0x10, 0x20},
                OpCodeMnemonic = "mov",
                StackFrames = new List<StackFrameEntity>
                {
                    new StackFrameEntity
                    {
                        StackPointer = 100.ToByteArray(),
                        ReturnAddress = 700.ToByteArray(),
                        ModuleName = "mymod",
                        Function = "myfun",
                        Offset = 30.ToByteArray()
                    }
                },
                Notes = new List<NoteEntity>
                {
                    new NoteEntity
                    {
                        CreateDate = DateTime.MinValue,
                        Text = "note"
                    }
                }
            });
            var newFrames = new[]
            {
                new Frame
                {
                    Position = new Position(0, 0),
                    ThreadId = 1,
                    RegisterSet = new RegisterSet
                    {
                        Rax = 2,
                        Rbx = 4,
                        Rcx = 6,
                        Rdx = 8
                    },
                    DisassemblyLine = new DisassemblyLine(90, new byte[] {0x10, 0x20}, "mov", "r9,r8"),
                    StackTrace = new StackTrace(new[]
                    {
                        new StackFrame(100, 700, "mymod", "myfun", 30),
                        new StackFrame(200, 900, "mymod", "myfun2", 20)
                    }),
                    Notes = new List<Note>
                    {
                        new Note
                        {
                            CreateDate = DateTime.MinValue,
                            Text = "note"
                        }
                    }
                },
                new Frame
                {
                    Position = new Position(1, 0),
                    ThreadId = 1,
                    RegisterSet = new RegisterSet
                    {
                        Rax = 13,
                        Rbx = 4
                    }
                }
            };
            access.ContextFactory = builder.Build();
            access.UpsertFrames("", newFrames);
            access.GetFrame("", new Position(0, 0), 1).RegisterSet.Rax.Should().Be(2);
            access.GetFrame("", new Position(0, 0), 1).RegisterSet.Rbx.Should().Be(4);
            access.GetFrame("", new Position(1, 0), 1).RegisterSet.Rax.Should().Be(13);
            access.GetFrame("", new Position(1, 0), 1).RegisterSet.Rbx.Should().Be(4);
        }
    }
}