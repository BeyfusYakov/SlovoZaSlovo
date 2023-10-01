using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class Graph
    {
        Point[,] points = new Point[5,5] ;
        List<Edge> edges = new();
        public void AddEdges(Point from, Point to)
        {
            edges.Add(new Edge(from, to));
        }

        Graph(Point[,] points, List<Edge> edges)
        {
            this.points = points ;
            this.edges = edges ;
        }


        public List<Vertex> GetVetexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }
    }
}
