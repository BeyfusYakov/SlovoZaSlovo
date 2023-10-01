using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class Edge
    {
        public Point From { get; set; }
        public Point To { get; set; }
        public int Weight; 
        public Edge(Point from, Point to, int weight = 1)
        {
            From = from; 
            To = to;
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"{From} - {To}" ;
        }
    }
}
