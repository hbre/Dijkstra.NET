namespace Dijkstra.NET.Model
{
    using System;
    using System.Collections.Generic;

    public class Matrix
    {
        private readonly uint _defaultValue;

        private readonly Dictionary<Index, uint> _container;

        public Matrix(int capacity)
        {
            _container = new Dictionary<Index, uint>(capacity);
        }

        public Matrix(int capacity, uint deafult) : this(capacity)
        {
            _defaultValue = deafult;
        }

        public uint this[uint x, uint y]
        {
            get
            {
                var key = new Index(x, y);

                return _container.ContainsKey(key) ? _container[key] : _defaultValue;
            }
            set
            {
                var key = new Index(x, y);
                _container[key] = value;
            }
        }

        private struct Index : IEquatable<Index>
        {
            public Index(uint x, uint y)
            {
                X = x;
                Y = y;
            }

            public bool Equals(Index other)
            {
                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (obj.GetType() != GetType())
                {
                    return false;
                }

                return Equals((Index) obj);
            }

            public override int GetHashCode()
            {
                int hash = 13;
                hash = hash * 7 + X.GetHashCode();
                hash = hash * 7 + Y.GetHashCode();
                return hash;
            }

            private UInt32 X { get; }
            private UInt32 Y { get; }
        }
    }
}
