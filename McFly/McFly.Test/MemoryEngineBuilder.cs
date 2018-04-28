﻿using McFly.WinDbg;
using McFly.WinDbg.Debugger;
using Moq;

namespace McFly.Test
{
    internal class MemoryEngineBuilder
    {
        public Mock<IMemoryEngine> Mock = new Mock<IMemoryEngine>();

        public MemoryEngineBuilder WithReadMemory(byte[] bytes)
        {
            Mock.Setup(engine => engine.ReadMemory(It.IsAny<ulong>(), It.IsAny<ulong>(), It.IsAny<IDebugDataSpaces>())).Returns(bytes);
            return this;
        }

        public MemoryEngineBuilder WithReadMemory(ulong start, ulong end, IDebugDataSpaces spaces, bool is32Bit, byte[] bytes)
        {
            Mock.Setup(engine => engine.ReadMemory(start, end, spaces)).Returns(bytes);
            return this;
        }

        public IMemoryEngine Build()
        {
            return Mock.Object;
        }
    }
}