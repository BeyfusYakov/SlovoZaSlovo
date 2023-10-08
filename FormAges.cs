using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class FormAges
    {

        public static List<Edge> CreateEdges(Point[,] Arr)
        {
            List<Edge> edges = new List<Edge>();
            Point lastPoint;
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    {
                        lastPoint = Arr[i, j];
                        if (lastPoint.X - 1 >= 0 && lastPoint.Y - 1 >= 0) edges.Add(new Edge(Arr[i, j], Arr[i - 1, j - 1]));
                        if (lastPoint.X - 1 >= 0) edges.Add(new Edge(Arr[i, j], Arr[i - 1, j]));
                        if (lastPoint.X - 1 >= 0 && lastPoint.Y + 1 < cols) edges.Add(new Edge(Arr[i, j], Arr[i - 1, j + 1]));
                        if (lastPoint.Y - 1 >= 0) edges.Add(new Edge(Arr[i, j], Arr[i, j - 1]));
                        if (lastPoint.Y + 1 < rows) edges.Add(new Edge(Arr[i, j], Arr[i, j + 1]));
                        if (lastPoint.X + 1 < rows && lastPoint.Y - 1 >= 0) edges.Add(new Edge(Arr[i, j], Arr[i + 1, j - 1]));
                        if (lastPoint.X + 1 < rows) edges.Add(new Edge(Arr[i, j], Arr[i + 1, j]));
                        if (lastPoint.X + 1 < rows && lastPoint.Y + 1 < cols) edges.Add(new Edge(Arr[i, j], Arr[i + 1, j + 1]));
                    }
                }
            }
            return edges;
        }
    }
}
