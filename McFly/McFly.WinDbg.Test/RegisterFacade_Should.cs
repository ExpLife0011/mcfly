﻿using System.Linq;
using FluentAssertions;
using McFly.Core.Registers;
using McFly.WinDbg.Test.Builders;
using Xunit;

namespace McFly.WinDbg.Test
{
    public class RegisterFacade_Should
    {
        [Fact]
        public void Set_RegisterSet_Values_Correctly()
        {
            var facade = new RegisterFacade();
            facade.DebugEngineProxy = new DebugEngineProxyBuilder()
                .WithGetRegisterValue(Enumerable.Repeat(0xff, 32).Select(x => (byte) x).ToArray())
                .Build();

            var r = facade.GetCurrentRegisterSet(Register.All);

            r.Of.Should().BeTrue();
            r.Df.Should().BeTrue();
            r.If.Should().BeTrue();
            r.Tf.Should().BeTrue();
            r.Sf.Should().BeTrue();
            r.Zf.Should().BeTrue();
            r.Af.Should().BeTrue();
            r.Pf.Should().BeTrue();
            r.Cf.Should().BeTrue();
            r.Vip.Should().BeTrue();
            r.Vif.Should().BeTrue();
            r.Al.Should().Be(byte.MaxValue);
            r.Cl.Should().Be(byte.MaxValue);
            r.Dl.Should().Be(byte.MaxValue);
            r.Bl.Should().Be(byte.MaxValue);
            r.Spl.Should().Be(byte.MaxValue);
            r.Bpl.Should().Be(byte.MaxValue);
            r.Sil.Should().Be(byte.MaxValue);
            r.Dil.Should().Be(byte.MaxValue);
            r.R8b.Should().Be(byte.MaxValue);
            r.R9b.Should().Be(byte.MaxValue);
            r.R10b.Should().Be(byte.MaxValue);
            r.R11b.Should().Be(byte.MaxValue);
            r.R12b.Should().Be(byte.MaxValue);
            r.R13b.Should().Be(byte.MaxValue);
            r.R14b.Should().Be(byte.MaxValue);
            r.R15b.Should().Be(byte.MaxValue);
            r.Ah.Should().Be(byte.MaxValue);
            r.Ch.Should().Be(byte.MaxValue);
            r.Dh.Should().Be(byte.MaxValue);
            r.Bh.Should().Be(byte.MaxValue);
            r.Cs.Should().Be(ushort.MaxValue);
            r.Ds.Should().Be(ushort.MaxValue);
            r.Es.Should().Be(ushort.MaxValue);
            r.Fs.Should().Be(ushort.MaxValue);
            r.Gs.Should().Be(ushort.MaxValue);
            r.Ss.Should().Be(ushort.MaxValue);
            r.Fpcw.Should().Be(ushort.MaxValue);
            r.Fpsw.Should().Be(ushort.MaxValue);
            r.Fptw.Should().Be(ushort.MaxValue);
            r.Ax.Should().Be(ushort.MaxValue);
            r.Cx.Should().Be(ushort.MaxValue);
            r.Dx.Should().Be(ushort.MaxValue);
            r.Bx.Should().Be(ushort.MaxValue);
            r.Sp.Should().Be(ushort.MaxValue);
            r.Bp.Should().Be(ushort.MaxValue);
            r.Si.Should().Be(ushort.MaxValue);
            r.Di.Should().Be(ushort.MaxValue);
            r.R8w.Should().Be(ushort.MaxValue);
            r.R9w.Should().Be(ushort.MaxValue);
            r.R10w.Should().Be(ushort.MaxValue);
            r.R11w.Should().Be(ushort.MaxValue);
            r.R12w.Should().Be(ushort.MaxValue);
            r.R13w.Should().Be(ushort.MaxValue);
            r.R14w.Should().Be(ushort.MaxValue);
            r.R15w.Should().Be(ushort.MaxValue);
            r.Ip.Should().Be(ushort.MaxValue);
            r.Fl.Should().Be(ushort.MaxValue);
            r.Fopcode.Should().Be(ushort.MaxValue);
            r.Efl.Should().Be(uint.MaxValue);
            r.Mxcsr.Should().Be(uint.MaxValue);
            r.Eax.Should().Be(uint.MaxValue);
            r.Ecx.Should().Be(uint.MaxValue);
            r.Edx.Should().Be(uint.MaxValue);
            r.Ebx.Should().Be(uint.MaxValue);
            r.Esp.Should().Be(uint.MaxValue);
            r.Ebp.Should().Be(uint.MaxValue);
            r.Esi.Should().Be(uint.MaxValue);
            r.Edi.Should().Be(uint.MaxValue);
            r.R8d.Should().Be(uint.MaxValue);
            r.R9d.Should().Be(uint.MaxValue);
            r.R10d.Should().Be(uint.MaxValue);
            r.R11d.Should().Be(uint.MaxValue);
            r.R12d.Should().Be(uint.MaxValue);
            r.R13d.Should().Be(uint.MaxValue);
            r.R14d.Should().Be(uint.MaxValue);
            r.R15d.Should().Be(uint.MaxValue);
            r.Eip.Should().Be(uint.MaxValue);
            r.Fpip.Should().Be(uint.MaxValue);
            r.Fpipsel.Should().Be(uint.MaxValue);
            r.Fpdp.Should().Be(uint.MaxValue);
            r.Fpdpsel.Should().Be(uint.MaxValue);
            r.Rax.Should().Be(ulong.MaxValue);
            r.Rcx.Should().Be(ulong.MaxValue);
            r.Rdx.Should().Be(ulong.MaxValue);
            r.Rbx.Should().Be(ulong.MaxValue);
            r.Rsp.Should().Be(ulong.MaxValue);
            r.Rbp.Should().Be(ulong.MaxValue);
            r.Rsi.Should().Be(ulong.MaxValue);
            r.Rdi.Should().Be(ulong.MaxValue);
            r.R8.Should().Be(ulong.MaxValue);
            r.R9.Should().Be(ulong.MaxValue);
            r.R10.Should().Be(ulong.MaxValue);
            r.R11.Should().Be(ulong.MaxValue);
            r.R12.Should().Be(ulong.MaxValue);
            r.R13.Should().Be(ulong.MaxValue);
            r.R14.Should().Be(ulong.MaxValue);
            r.R15.Should().Be(ulong.MaxValue);
            r.Rip.Should().Be(ulong.MaxValue);
            r.Dr0.Should().Be(ulong.MaxValue);
            r.Dr1.Should().Be(ulong.MaxValue);
            r.Dr2.Should().Be(ulong.MaxValue);
            r.Dr3.Should().Be(ulong.MaxValue);
            r.Dr6.Should().Be(ulong.MaxValue);
            r.Dr7.Should().Be(ulong.MaxValue);
            r.Mm0.Should().Be(ulong.MaxValue);
            r.Mm1.Should().Be(ulong.MaxValue);
            r.Mm2.Should().Be(ulong.MaxValue);
            r.Mm3.Should().Be(ulong.MaxValue);
            r.Mm4.Should().Be(ulong.MaxValue);
            r.Mm5.Should().Be(ulong.MaxValue);
            r.Mm6.Should().Be(ulong.MaxValue);
            r.Mm7.Should().Be(ulong.MaxValue);
            r.Xmm0l.Should().Be(ulong.MaxValue);
            r.Xmm1l.Should().Be(ulong.MaxValue);
            r.Xmm2l.Should().Be(ulong.MaxValue);
            r.Xmm3l.Should().Be(ulong.MaxValue);
            r.Xmm4l.Should().Be(ulong.MaxValue);
            r.Xmm5l.Should().Be(ulong.MaxValue);
            r.Xmm6l.Should().Be(ulong.MaxValue);
            r.Xmm7l.Should().Be(ulong.MaxValue);
            r.Xmm8l.Should().Be(ulong.MaxValue);
            r.Xmm9l.Should().Be(ulong.MaxValue);
            r.Xmm10l.Should().Be(ulong.MaxValue);
            r.Xmm11l.Should().Be(ulong.MaxValue);
            r.Xmm12l.Should().Be(ulong.MaxValue);
            r.Xmm13l.Should().Be(ulong.MaxValue);
            r.Xmm14l.Should().Be(ulong.MaxValue);
            r.Xmm15l.Should().Be(ulong.MaxValue);
            r.Xmm0h.Should().Be(ulong.MaxValue);
            r.Xmm1h.Should().Be(ulong.MaxValue);
            r.Xmm2h.Should().Be(ulong.MaxValue);
            r.Xmm3h.Should().Be(ulong.MaxValue);
            r.Xmm4h.Should().Be(ulong.MaxValue);
            r.Xmm5h.Should().Be(ulong.MaxValue);
            r.Xmm6h.Should().Be(ulong.MaxValue);
            r.Xmm7h.Should().Be(ulong.MaxValue);
            r.Xmm8h.Should().Be(ulong.MaxValue);
            r.Xmm9h.Should().Be(ulong.MaxValue);
            r.Xmm10h.Should().Be(ulong.MaxValue);
            r.Xmm11h.Should().Be(ulong.MaxValue);
            r.Xmm12h.Should().Be(ulong.MaxValue);
            r.Xmm13h.Should().Be(ulong.MaxValue);
            r.Xmm14h.Should().Be(ulong.MaxValue);
            r.Xmm15h.Should().Be(ulong.MaxValue);
            r.Exfrom.Should().Be(ulong.MaxValue);
            r.Exto.Should().Be(ulong.MaxValue);
            r.Brfrom.Should().Be(ulong.MaxValue);
            r.Brto.Should().Be(ulong.MaxValue);
            r.St0.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St1.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St2.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St3.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St4.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St5.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St6.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.St7.SequenceEqual(Enumerable.Repeat<byte>(0xff, 10)).Should().BeTrue();
            r.Xmm0.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm1.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm2.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm3.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm4.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm5.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm6.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm7.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm8.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm9.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm10.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm11.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm12.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm13.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm14.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Xmm15.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm0l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm1l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm2l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm3l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm4l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm5l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm6l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm7l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm8l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm9l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm10l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm11l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm12l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm13l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm14l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm15l.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm0h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm1h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm2h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm3h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm4h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm5h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm6h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm7h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm8h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm9h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm10h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm11h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm12h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm13h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm14h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm15h.SequenceEqual(Enumerable.Repeat<byte>(0xff, 16)).Should().BeTrue();
            r.Ymm0.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm1.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm2.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm3.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm4.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm5.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm6.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm7.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm8.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm9.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm10.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm11.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm12.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm13.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm14.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
            r.Ymm15.SequenceEqual(Enumerable.Repeat<byte>(0xff, 32)).Should().BeTrue();
        }
    }
}