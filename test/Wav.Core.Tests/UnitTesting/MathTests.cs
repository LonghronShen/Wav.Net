using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using WavMath = WavDotNet.Tools.Math;

namespace WavDotNet.Tests.UnitTesting
{

    public class MathTests
    {

        [Fact]
        public void TestToDecibels()
        {
            Assert.Equal(20, WavMath.ToDecibels(10D));
            Assert.Equal(20, WavMath.ToDecibels(10F));
            Assert.Equal(40, WavMath.ToDecibels(100D));
            Assert.Equal(40, WavMath.ToDecibels(100F));
        }

        [Fact]
        public void TestToAmplitude()
        {
            Assert.Equal(100000, WavMath.ToAmplitude(100D));
            Assert.Equal(100000, WavMath.ToAmplitude(100F));
        }

    }

}