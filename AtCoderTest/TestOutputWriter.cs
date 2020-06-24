using System.Collections.Generic;
using System.Text;
using AtCoder;

namespace AtCoderTest
{
    internal class TestOutputWriter : IOutputWriter
    {
        private List<string> _outputs { get; set; } = new List<string>();

        public string OutputLines
        {
            get
            {
                var sb = new StringBuilder();
                sb.AppendLine();
                foreach (var output in _outputs)
                {
                    sb.AppendLine(output);
                }

                return sb.ToString();
            }
        }

        public void WriteLine(string output)
        {
            _outputs.Add(output);
        }
    }
}