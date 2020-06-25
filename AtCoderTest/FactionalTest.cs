using System.Reflection.Metadata.Ecma335;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class FactionalTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        [InlineData(9, 362880)]
        [InlineData(10, 3628800)]
        [InlineData(11, 39916800)]
        [InlineData(12, 479001600)]
        [InlineData(13, 227020758)]
        [InlineData(14, 178290591)]
        [InlineData(15, 674358851)]
        [InlineData(16, 789741546)]
        [InlineData(17, 425606191)]
        [InlineData(18, 660911389)]
        [InlineData(19, 557316307)]
        public void Test(long n, long expected)
        {
            Assert.Equal((long) expected, Util.ModFactional(n));
        }
    }
}