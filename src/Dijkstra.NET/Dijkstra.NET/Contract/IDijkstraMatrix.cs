namespace Dijkstra.NET.Contract
{
    using Model;

    public interface IDijkstraMatrix: IDijkstra
    {
        DijkstraResult Process(uint @from, uint to, Matrix m);
    }
}
