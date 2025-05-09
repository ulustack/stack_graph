using System;
using System.Collections.Generic;

namespace SocialNetwork
{
    public class Graph<T>
    {
        private Dictionary<T, List<T>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<T, List<T>>();
        }

        public void AddVertex(T vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<T>();
            }
        }

        public void AddEdge(T vertex1, T vertex2)
        {
            if (!adjacencyList.ContainsKey(vertex1))
                AddVertex(vertex1);
            if (!adjacencyList.ContainsKey(vertex2))
                AddVertex(vertex2);

            adjacencyList[vertex1].Add(vertex2);
        }

        public List<T> GetNeighbors(T vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
                throw new InvalidOperationException("Bağlantı bulunamadı.");
            return adjacencyList[vertex];
        }

        public void ShowConnections(T vertex)
        {
            Console.WriteLine($"{vertex} ile olan bağlantılar:");
            foreach (var neighbor in adjacencyList[vertex])
            {
                Console.WriteLine(neighbor);
            }
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.WriteLine($"{vertex.Key} -> {string.Join(", ", vertex.Value)}");
            }
        }
    }
}
