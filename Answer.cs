using Microsoft.VisualBasic.ApplicationServices;
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
            return $"{Word} - [{string.Join(", ", Points)}]";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Word, this.Cost);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Answer;
            if (other == null)
            {
                return false;
            }
            return object.Equals(this.Word, other.Word) && this.Cost == other.Cost;
        }

        public Answer(string word, int cost, List<Point> points)
        {
            Word = word;
            Cost = cost;
            Points = points;
        }

    }
}
