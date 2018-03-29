﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace McFly.Tests
{
    public class AccessBreakpoint_Should
    {
        [Fact]
        public void Exhibit_Value_Equality()
        {
            var a1 = new AccessBreakpoint(0,4,true,false);
            var a2 = new AccessBreakpoint(0, 4, true, false);

            a1.Equals(a1).Should().BeTrue();
            a1.Equals((object) a1).Should().BeTrue();
            a1.Equals(a2).Should().BeTrue();
            (a1 == a2).Should().BeTrue();
            (a1 != a2).Should().BeFalse();
            a1.GetHashCode().Should().Be(a2.GetHashCode());
        }
    }
}
