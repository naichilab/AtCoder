using System.IO;
using System.Linq;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("a", 'a')]
        [InlineData("b", 'b')]
        [InlineData("Z", 'Z')]
        public void TestStringToChar(string text, char expected)
        {
            Assert.Equal(expected, text.ToChar());
        }

        [Theory]
        [InlineData("aa bb cc", new[] {"aa", "bb", "cc"})]
        public void TestStringToStringArray(string text, string[] expected)
        {
            Assert.Equal(expected, text.ToStringArray());
        }


        [Theory]
        [InlineData("-1", -1)]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("-2147483648", -2147483648)]
        [InlineData("2147483647", 2147483647)]
        public void TestStringToInt(string text, int expected)
        {
            Assert.Equal(expected, text.ToInt());
        }

        [Theory]
        [InlineData("1 2 3", new[] {1, 2, 3})]
        public void TestStringToIntArray(string text, int[] expected)
        {
            Assert.Equal(expected, text.ToIntArray());
        }

        [Theory]
        [InlineData("-1", -1L)]
        [InlineData("0", 0)]
        [InlineData("1", 1L)]
        [InlineData("-9223372036854775808", -9223372036854775808L)]
        [InlineData("9223372036854775807", 9223372036854775807L)]
        public void TestStringToLong(string text, long expected)
        {
            Assert.Equal(expected, text.ToLong());
        }

        [Theory]
        [InlineData("1 2 3", new[] {1L, 2L, 3L})]
        public void TestStringToLongArray(string text, long[] expected)
        {
            Assert.Equal(expected, text.ToLongArray());
        }

        [Theory]
        [InlineData(new[] {"a", "b", "c"}, "abc")]
        public void TestStringArrayToJoinedString(string[] inputs, string expected)
        {
            Assert.Equal(expected, inputs.ToJoinedString());
        }
        [Theory]
        [InlineData(new[] {'a','b','c'}, "abc")]
        public void TestCharArrayToJoinedString(char[] inputs, string expected)
        {
            Assert.Equal(expected, inputs.ToJoinedString());
        }

    }
}