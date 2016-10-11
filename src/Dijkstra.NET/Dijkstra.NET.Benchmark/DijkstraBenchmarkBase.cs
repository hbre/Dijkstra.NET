﻿namespace Dijkstra.NET.Benchmark
{
    using System;
    using Model;

    public abstract class DijkstraBenchmarkBase
    {
        protected readonly Graph<int, string> _graph = new Graph<int, string>();

        private const int Nodes = 1000000;
        private const int Connections = 10000000;

        protected uint from;
        protected uint to;

        public void Setup()
        {
            for (int i = 0; i < Nodes; i++)
                _graph.AddNode(i);

            var random = new Random();

            for (int i = 0; i < Connections; i++)
            {
                int node1 = random.Next(1, Nodes);
                int node2 = random.Next(1, Nodes);
                int cost = random.Next(1, 50);

                _graph.Connect((uint) node1, (uint) node2, (uint) cost, null);
            }

            @from = (uint) random.Next(0, Nodes-1);
            to = (uint) random.Next(0, Nodes-1);
        }

        public abstract DijkstraResult GetPath();
    }
}
