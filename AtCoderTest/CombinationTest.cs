using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class CombinationTest
    {
        [Fact]
        public void TestCombination1()
        {
            Assert.Equal((5 * 4 * 3 * 2 * 1) / ((2 * 1) * (3 * 2 * 1)), Util.Combination(5, 2));
        }
    }
}