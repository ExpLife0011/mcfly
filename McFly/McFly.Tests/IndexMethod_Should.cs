﻿using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using McFly.Core;
using Xunit;

namespace McFly.Tests
{
    public class IndexMethod_Should
    {
        [Fact]
        public void Create_Frame_Correctly()
        {
            // arrange
            var builder = new DbgEngProxyBuilder();
            builder.WithExecuteResult("u rip L1", "00007ffa`51315543 6645898632010000 mov     word ptr [r14+132h],r8w");
            var indexMethod = new IndexMethod {DbgEngProxy = builder.Build()};

            // act
            var frame = indexMethod.CreateFrame(false, new PositionsRecord(1, new Position(0, 0), true),
                new RegisterSet(), new List<StackFrame>());

            // assert
        }

        [Fact]
        public void Get_Current_Instruction_Disassembly()
        {
            var builder = new DbgEngProxyBuilder();
            builder.WithExecuteResult("u rip L1",
                @"KERNEL32!GetTimeFormatWWorker+0xc43:
00007ffa`51315543 6645898632010000 mov     word ptr [r14+132h],r8w");
            var indexMethod = new IndexMethod();
            indexMethod.DbgEngProxy = builder.Build();

            var line = indexMethod.GetCurrentDisassemblyLine(false);

            line.InstructionAddress.Should().Be(0x7ffa51315543, "The first ulong is the instruction address");
            line.OpCode.Should().Equal(new byte[] {0x66, 0x45, 0x89, 0x86, 0x32, 0x01, 0x00, 0x00},
                "The op code follows the instruction address and varies in length");
            line.OpCodeMnemonic.Should().Be("mov", "The opcode mnemonic follows the opcode");
            line.DisassemblyNote.Should().Be("word ptr [r14+132h],r8w", "The disassembly note is last");

        }

        [Fact]
        public void Get_Stack_Frames_Correctly()
        {
            // arrange
            var stackTrace = @"00000000`0014d1d0 00007ffa`513138e6 KERNEL32!GetTimeFormatWWorker+0x7ed
00000000`0014d220 00007ffa`513165ee KERNEL32!QuirkIsEnabledForPackageWorker";

            var expected = new[]
            {
                new StackFrame(0x014d1d0, 0x0007ffa513138e6, "KERNEL32", "GetTimeFormatWWorker", 0x7ed),
                new StackFrame(0x014d220, 0x0007ffa513165ee, "KERNEL32", "QuirkIsEnabledForPackageWorker", 0)
            };

            // act                                                                           
            // assert
            IndexMethod.GetStackFrames(stackTrace).Should().Equal(expected);
        }

        [Fact]
        public void Get_Thread_Positions_Correctly()
        {
            // arrange
            var indexMethod = new IndexMethod();
            var builder = new DbgEngProxyBuilder();
            builder.WithExecuteResult("!positions", @">Thread ID=0x7590 - Position: 168CC:0
 Thread ID=0x12A0 - Position: 211F5:0
 Thread ID=0x6CDC - Position: 21D59:0");
            indexMethod.DbgEngProxy = builder.Build();
            var expected = new[]
            {
                new PositionsRecord(0x7590, new Position(0x168CC, 0), true),
                new PositionsRecord(0x12A0, new Position(0x211F5, 0), false),
                new PositionsRecord(0x6CDC, new Position(0x21D59, 0), false)
            };

            // act
            var actual = indexMethod.GetPositions();

            // assert
            actual.SequenceEqual(expected).Should()
                .BeTrue("This is the pattern: >Thread ID=0x7590 - Position: 168CC:0");
        }

        [Fact]
        public void Identify_32_And_64_Bit_Arch()
        {
            // Arrange
            var builder = new DbgEngProxyBuilder();
            builder.WithExecuteResult("!peb", @"PEB at 00000000003b9000
    InheritedAddressSpace:    No
    ReadImageFileExecOptions: No
    BeingDebugged:            No
    ...
    ImageBaseAddress:         0000000140000000        _NT_SYMBOL_PATH=SRV*c:\symbols*http://msdl.microsoft.com/download/symbols");
            var proxy = builder.Build();

            // Act
            var indexMethod = new IndexMethod();
            indexMethod.DbgEngProxy = builder.Build();
            var is32 = indexMethod.Is32Bit();

            // Assert
            is32.Should().BeFalse("00000000003b9000 is 16 characters and thus 64bit");
        }

        [Fact]
        public void Identify_Correct_Starting_Position()
        {
            // Arrange                             
            var options = new IndexOptions
            {
                Start = "35:1"
            };
            var invalidStartOptions = new IndexOptions
            {
                Start = "hello there"
            };
            var indexMethod = new IndexMethod();
            var builder = new DbgEngProxyBuilder();
            builder.WithStartingPosition(new Position(0x35, 0));
            indexMethod.DbgEngProxy = builder.Build();

            // Act
            var startingPosition = indexMethod.GetStartingPosition(options);
            var invalidStartPosition = indexMethod.GetStartingPosition(invalidStartOptions);

            // Assert
            startingPosition.Should().Be(new Position(0x35, 1),
                "35:1 means that the high portion is 35 and the low portion is 1");              
            invalidStartPosition.Should().Be(new Position(0, 0),
                "Any invalid input should result in a default position of 0:0");
        }

        [Fact]
        public void Identify_Correct_Ending_Position()
        {
            var options = new IndexOptions
            {
                End = "1:0"
            };

            var indexMethod = new IndexMethod();
            var builder = new DbgEngProxyBuilder();
            builder.WithEndingPosition(new Position(0, 0));
            indexMethod.DbgEngProxy = builder.Build();

            var position = indexMethod.GetEndingPosition(options);
            var position2 = indexMethod.GetEndingPosition(new IndexOptions());

            position.Should().Be(new Position(1, 0));
            position2.Should().Be(new Position(0, 0));
        }
    }
}