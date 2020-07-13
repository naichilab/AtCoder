using System.IO;
using System.Linq;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class BoolExtensionsTest
    {
        [Theory]
        [InlineData(true, "Yes")]
        [InlineData(false, "No")]
        public void TestToYesNo(bool value, string expected)
        {
            Assert.Equal(expected, value.ToYesNo());
        }

        [Theory]
        [InlineData(true, "YES")]
        [InlineData(false, "NO")]
        public void TestToYESNO(bool value, string expected)
        {
            Assert.Equal(expected, value.ToYESNO());
        }
    }
}