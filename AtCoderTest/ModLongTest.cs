using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModLongTest
    {
        private const long Mod = 1000000007;

        [Fact]
        public void 等価性()
        {
            Assert.Equal(new ModLong(1), new ModLong(1));
        }

        [Fact]
        public void Longとの相互キャスト()
        {
            Assert.Equal(new ModLong(100L), (ModLong)100L);
            Assert.Equal(123, (long) new ModLong(123));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("12345", new ModLong(12345).ToString());
            Assert.Equal("567", new ModLong(567).ToString());
            Assert.Equal("1111111", new ModLong(1111111).ToString());
        }

        [Fact]
        public void 生成()
        {
            Assert.Equal(new ModLong(12345), new ModLong(12345));
            Assert.Equal(new ModLong(12345), (ModLong) 12345);
            Assert.Equal(99999999999L % Mod, (long) new ModLong(99999999999));
        }


        [Fact]
        public void 足し算()
        {
            Assert.Equal((99999999999L + 99999999999L) % Mod, (long) ((ModLong) 99999999999L + (ModLong)99999999999L));
        }

        [Fact]
        public void 引き算()
        {
            Assert.Equal((2000000020 - 20) % Mod, (long) ((ModLong) 2000000020 - (ModLong)20));
        }

        [Fact]
        public void 掛け算()
        {
            Assert.Equal((12345678L * 12345678L) % Mod, (long) ((ModLong) 12345678 * (ModLong)12345678));
        }

        [Fact]
        public void 割り算()
        {
            Assert.Equal(123456789, (long) (new ModLong(678813585) / new ModLong(100000)));
            Assert.Equal(123456789, (long) (new ModLong(12345678900000) / new ModLong(100000)));
            Assert.Equal(123456789, (long) (new ModLong(1234567890000000000) / new ModLong(10000000000)));
        }
    }
}