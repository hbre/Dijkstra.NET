namespace Dijkstra.NET.Contract
{
    using Model;

    public interface IDijkstra
    {
        DijkstraResult Process(uint from, uint to);
    }
}
