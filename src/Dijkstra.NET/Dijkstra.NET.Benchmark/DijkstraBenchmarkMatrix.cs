namespace Dijkstra.NET.Benchmark
{
    using Model;

    public class DijkstraBenchmarkMatrix : DijkstraBenchmarkBase
    {
        public override DijkstraResult GetPath()
        {
            var dijkstra = new DijkstraMatrix(_graph);
            return dijkstra.Process(@from, to);
        }
    }
}
