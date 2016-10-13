namespace Dijkstra.NET.Benchmark
{
    using System;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;

    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<DijkstraBenchmark>(DefaultConfig.Instance.With(Job.Dry));
        }
    }
}
