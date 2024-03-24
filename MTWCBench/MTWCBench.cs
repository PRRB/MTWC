using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MTWC;

#pragma warning disable CA1822 // Mark members as static
namespace MTWCBench
{
    [SimpleJob(RuntimeMoniker.Net60, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.Net50, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.NetCoreApp21, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.Net48, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.Net472, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [SimpleJob(RuntimeMoniker.Net462, launchCount: 2, warmupCount: 2, iterationCount: 5)]
    [MemoryDiagnoser]
    public class MTWCBench
    {
        [Benchmark]
        public MTWCData ParseMTWCData()
        {
            return new MTWCData();
        }
    }
}