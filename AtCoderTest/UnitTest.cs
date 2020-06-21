using System.Collections.Generic;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(new string[] {"2"}, new string[] {"b"})]
        [InlineData(new string[] {"27"}, new string[] {"aa"})]
        [InlineData(new string[] {"123456789"}, new string[] {"jjddja"})]
        public void Test(string[] inputs, string[] expectOutputs)
        {
            var reader = new TestInputReader(inputs);
            var writer = new TestOutputWriter();
            new Solver(reader, writer).Solve();
            Assert.Equal(expectOutputs, writer.Outputs);
        }
        
        
        
        
        
        
    }
}