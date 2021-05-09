using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MTWC;

namespace MTWCBench
{
    [SimpleJob(RuntimeMoniker.Net48, launchCount: 2, warmupCount: 3, targetCount: 6)]
    [SimpleJob(RuntimeMoniker.NetCoreApp21, launchCount: 2, warmupCount: 3, targetCount: 6)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31, launchCount: 2, warmupCount: 3, targetCount: 6)]
    [SimpleJob(RuntimeMoniker.NetCoreApp50, launchCount: 2, warmupCount: 3, targetCount: 6)]
    [MemoryDiagnoser]
    public class MTWCDataBench
    {
        public MTWCDataBench()
        { }

        [Benchmark]
        public MTWCData ParseMTWCData()
        {
            return new MTWCData();
        }
    }
}