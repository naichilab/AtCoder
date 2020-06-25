using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModCombinationTest
    {
        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(2, 3, 0)]
        [InlineData(3, 0, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 2, 3)]
        [InlineData(5, 2, 10)]
        [InlineData(13, 3, 286)]
        public void Test組み合わせ(long m, long n, long expected)
        {
            var c = new ModCombination();
            Assert.Equal(expected, c.Combination(m, n));
        }
    }
}