using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModLongTest
    {
        [Fact]
        public void 等価性()
        {
            Assert.Equal(new ModLong(1), new ModLong(1));
        }

        [Fact]
        public void 型変換()
        {
            Assert.Equal(new ModLong(1), (ModLong) 1);
            Assert.Equal(1, (long) new ModLong(1));
        }

        [Fact]
        public void 生成()
        {
            Assert.Equal(12345, (long) new ModLong(12345));
            Assert.Equal(99999999999L, (long) new ModLong(99999999999));
        }

        [Fact]
        public void 足し算()
        {
            Assert.Equal((99999999999L + 99999999999L) % 1000000007,
                (long) (new ModLong(99999999999L) + new ModLong(99999999999L)));
        }

        [Fact]
        public void 掛け算()
        {
            Assert.Equal((12345678L * 12345678L) % 1000000007,
                (long) (new ModLong(12345678) * new ModLong(12345678)));
        }

        [Fact]
        public void 引き算()
        {
            Assert.Equal(999999993,
                (long) (new ModLong(2000000020) - new ModLong(20)));
        }

        [Fact]
        public void TestAxBxC()
        {
            // Assert.Equal(769682799, new ModLong(111111111) * 123456789 * 987654321));
        }
    }
}