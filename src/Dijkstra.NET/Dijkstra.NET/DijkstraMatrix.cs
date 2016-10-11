namespace Dijkstra.NET
{
    using System;
    using Contract;
    using Model;

    public class DijkstraMatrix: IDijkstraMatrix
    {
        private readonly IMatrix _matrix;

        public DijkstraMatrix(IMatrix matrix)
        {
            _matrix = matrix;
        }

        public DijkstraMatrix()
        {
            
        }

        public DijkstraResult Process(uint @from, uint to)
        {
            Matrix m = _matrix.GetMatrix();
            return Process(from, to, m);
        }

        public DijkstraResult Process(uint @from, uint to, Matrix m)
        {
            throw new NotImplementedException();
        }
    }
}
