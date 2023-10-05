using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class Answer
    {
        public string Word { get; set; }
        public int Cost { get; set; }
        public List<Point> Points = new List<Point>();
        public override string ToString()
        {
            return $"{Word} - {Cost}";
        }

        public Answer(string word, int cost, List<Point> points)
        {
            Word = word;
            Cost = cost;
            Points = points;
        }

    }
}
