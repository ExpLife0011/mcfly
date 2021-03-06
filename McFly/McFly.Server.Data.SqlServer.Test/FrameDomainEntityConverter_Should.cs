﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using McFly.Core;
using McFly.Server.Data.SqlServer.Test.Builders;
using Moq;
using Xunit;

namespace McFly.Server.Data.SqlServer.Test
{
    public class FrameDomainEntityConverter_Should
    {
        [Fact]
        public void Convert_Between_Frame_And_FrameEntity_Correctly()
        {
            Frame frame;
            var converter = new FrameDomainEntityConverter();
            var builder = new ContextFactoryBuilder();
            var fac = builder.Build();
            var context = fac.GetContext("");

            {
                frame = new Frame();
                frame.RegisterSet.Af = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Af.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Cf = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Cf.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Df = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Df.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.If = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.If.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Of = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Of.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Pf = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Pf.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Sf = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Sf.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Tf = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Tf.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Vif = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Vif.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Vip = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Vip.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Zf = true;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Zf.Should().BeTrue();
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ah = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ah.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Al = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Al.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Bh = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Bh.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Bl = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Bl.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Bpl = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Bpl.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ch = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ch.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Cl = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Cl.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dh = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dh.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dil = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dil.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dl = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dl.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Iopl = 0x03;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Iopl.Should().Be(0x03);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R10b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R10b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R11b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R11b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R12b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R12b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R13b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R13b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R14b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R14b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R15b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R15b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R8b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R8b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R9b = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R9b.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Sil = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Sil.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Spl = byte.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Spl.Should().Be(byte.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ax = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ax.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Bp = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Bp.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Bx = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Bx.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Cs = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Cs.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Cx = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Cx.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Di = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Di.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ds = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ds.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dx = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dx.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Es = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Es.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fl = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fl.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fopcode = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fopcode.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpcw = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpcw.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpsw = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpsw.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fptw = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fptw.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fs = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fs.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Gs = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Gs.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ip = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ip.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R10w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R10w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R11w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R11w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R12w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R12w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R13w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R13w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R14w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R14w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R15w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R15w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R8w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R8w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R9w = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R9w.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Si = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Si.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Sp = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Sp.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ss = ushort.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ss.Should().Be(ushort.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Eax = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Eax.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ebp = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ebp.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ebx = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ebx.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Ecx = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ecx.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Edi = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Edi.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Edx = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Edx.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Efl = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Efl.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Eip = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Eip.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Esi = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Esi.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Esp = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Esp.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpdp = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpdp.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpdpsel = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpdpsel.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpip = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpip.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Fpipsel = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Fpipsel.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mxcsr = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mxcsr.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R10d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R10d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R11d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R11d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R12d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R12d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R13d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R13d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R14d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R14d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R15d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R15d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R8d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R8d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R9d = uint.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R9d.Should().Be(uint.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Brfrom = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Brfrom.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Brto = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Brto.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr0 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr0.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr1 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr1.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr2 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr2.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr3 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr3.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr6 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr6.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Dr7 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Dr7.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Exfrom = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Exfrom.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Exto = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Exto.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm0 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm0.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm1 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm1.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm2 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm2.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm3 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm3.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm4 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm4.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm5 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm5.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm6 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm6.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Mm7 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Mm7.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R10 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R10.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R11 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R11.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R12 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R12.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R13 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R13.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R14 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R14.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R15 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R15.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R8 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R8.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.R9 = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.R9.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rax = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rax.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rbp = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rbp.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rbx = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rbx.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rcx = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rcx.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rdi = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rdi.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rdx = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rdx.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rip = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rip.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rsi = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rsi.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Rsp = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Rsp.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm0h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm0h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm0l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm0l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm10h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm10h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm10l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm10l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm11h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm11h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm11l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm11l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm12h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm12h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm12l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm12l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm13h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm13h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm13l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm13l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm14h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm14h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm14l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm14l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm15h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm15h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm15l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm15l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm1h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm1h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm1l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm1l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm2h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm2h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm2l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm2l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm3h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm3h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm3l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm3l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm4h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm4h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm4l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm4l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm5h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm5h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm5l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm5l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm6h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm6h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm6l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm6l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm7h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm7h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm7l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm7l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm8h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm8h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm8l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm8l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm9h = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm9h.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                frame.RegisterSet.Xmm9l = ulong.MaxValue;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm9l.Should().Be(ulong.MaxValue);
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St0 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St0.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St1 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St1.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St2 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St2.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St3 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St3.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St4 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St4.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St5 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St5.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St6 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St6.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 10).Select(x => (byte) x).ToArray();
                frame.RegisterSet.St7 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.St7.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm0 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm0.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm1 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm1.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm10 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm10.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm11 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm11.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm12 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm12.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm13 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm13.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm14 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm14.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm15 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm15.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm2 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm2.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm3 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm3.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm4 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm4.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm5 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm5.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm6 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm6.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm7 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm7.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm8 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm8.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Xmm9 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Xmm9.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm0 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm0.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm0h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm0h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm0l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm0l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm1 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm1.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm10 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm10.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm10h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm10h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm10l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm10l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm11 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm11.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm11h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm11h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm11l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm11l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm12 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm12.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm12h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm12h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm12l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm12l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm13 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm13.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm13h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm13h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm13l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm13l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm14 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm14.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm14h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm14h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm14l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm14l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm15 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm15.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm15h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm15h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm15l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm15l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm1h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm1h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm1l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm1l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm2 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm2.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm2h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm2h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm2l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm2l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm3 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm3.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm3h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm3h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm3l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm3l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm4 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm4.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm4h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm4h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm4l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm4l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm5 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm5.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm5h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm5h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm5l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm5l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm6 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm6.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm6h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm6h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm6l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm6l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm7 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm7.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm7h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm7h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm7l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm7l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm8 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm8.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm8h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm8h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm8l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm8l.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 32).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm9 = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm9.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm9h = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm9h.SequenceEqual(bytes).Should().BeTrue();
            }
            {
                frame = new Frame();
                var bytes = Enumerable.Range(1, 16).Select(x => (byte) x).ToArray();
                frame.RegisterSet.Ymm9l = bytes;
                var entity = converter.ToEntity(frame, context);
                var convertedBack = converter.ToDomain(entity, context);
                convertedBack.RegisterSet.Ymm9l.SequenceEqual(bytes).Should().BeTrue();
            }
        }

        [Fact]
        public void Convert_Between_StackFrame_And_StackFrameEntity()
        {
            var converter = new FrameDomainEntityConverter();
            var builder = new ContextFactoryBuilder();
            var fac = builder.Build();
            var context = fac.GetContext("");
            var original = new StackFrame(0x100, 0x700, "mod0", "fun0", 0x10);
            var entity = converter.ExtractStackFrameEntity(Guid.Empty, original, context);
            entity.StackPointer.Should().Be("0001000000000000");
            entity.ReturnAddress.Should().Be("0007000000000000");
            entity.ModuleName.Should().Be("mod0");
            entity.Function.Should().Be("fun0");
            entity.Offset.Should().Be("1000000000000000");
            var convertedBack = converter.ExtractStackFrame(entity);
            convertedBack.Equals(original).Should().BeTrue();
        }

        [Fact]
        public void Return_The_Existing_Entity_If_One_Exists()
        {
            var guid = Guid.NewGuid();
            FrameEntity existingFrame = new FrameEntity()
            {
                Id = guid
            };
            var context = new ContextFactoryBuilder()
                .WithFrame(existingFrame)
                .Build()
                .GetContext("");
            var lookupFrame = new Frame()
            {
                Id = guid
            };
            var converter = new FrameDomainEntityConverter();
            converter.ToEntity(lookupFrame, context).Should().BeSameAs(existingFrame);
        }

        [Fact]
        public void Convert_The_StackTrace_Along_With_Conversion()
        {
            var frameEntity = new FrameEntity()
            {
                StackFrames = new List<StackFrameEntity>()
                {
                    new StackFrameEntity()
                    {
                        StackPointer = Convert.ToUInt64(0x100).ToHexString()
                    }
                }
            };
            var frame = new Frame()
            {
                StackTrace = new StackTrace(new List<StackFrame>()
                {
                    new StackFrame(0x100, null, null, null, null)
                })
            };
            var converter = new FrameDomainEntityConverter();
            var context = new ContextFactoryBuilder()
                .Build()
                .GetContext("");

            var fromEntity = converter.ToDomain(frameEntity, context);
            var fromDomain = converter.ToEntity(frame, context);

            fromEntity.StackTrace.StackFrames.Should().HaveCount(1);
            fromEntity.StackTrace.StackFrames.Single().StackPointer.Should().Be(0x100);

            fromDomain.StackFrames.Should().HaveCount(1);
            fromDomain.StackFrames.Single().StackPointer.Should().Be("0001000000000000");
        }
    }
}