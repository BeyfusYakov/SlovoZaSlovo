using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class Answer
    {
        public string word { get; set; }
        public int cost { get; set; }
        public List<Point> points = new List<Point>();

    }
}
