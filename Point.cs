using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{

    public class Point ///*record*/ работает медленнее
    {
        private int x;
        public int X { get => x; set => x = value; }
        private int y;
        public int Y { get => y; set => y = value; }
        private char val;
        public char Value { get => val; set => val = value; }
        private int factor;
        public int Factor { get => factor; set => factor = value; }

        public bool Visited;
        public Point(int x, int y, char val, int factor = 0)
        {
            this.X = x;
            this.Y = y;
            this.Value = val;
            this.Factor = factor;
        }
        public override string ToString()
        {
            return $"{X}.{Y} - {Value}";
        }

    }

}
