namespace Dijkstra.NET.Contract
{
    using Model;

    public interface IMatrix
    {
        Matrix GetMatrix();
        uint[] GetNodes();
    }
}
