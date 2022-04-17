using BenchmarkDotNet.Running;

namespace MTWCBench
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MTWCBench>();
        }
    }
}
