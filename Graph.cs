using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class Graph
    {
        public Point[,] Points = new Point[5,5] ;
        public List<Edge> Edges = new();
        public void AddEdges(Point from, Point to)
        {
            Edges.Add(new Edge(from, to));
        }

        public Graph(Point[,] points, List<Edge> edges)
        {
            this.Points = points ;
            this.Edges = edges ;
        }


        public List<Point> GetPointsList(Point point)
        {
            var result = new List<Point>();

            foreach (var edge in Edges)
            {
                if (edge.From == point)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }
    }
}
