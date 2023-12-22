using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{

    public class Point ///*record*/ работает медленнее
    {
        public readonly int X;
        public readonly int Y;
        public readonly char Val;
        public readonly int Factor;
        public Point(int x, int y, char val, int factor = 0)
        {
            this.X = x;
            this.Y = y;
            this.Val = val;
            this.Factor = factor;
        }
        public override string ToString()
        {
            return $"{Val}({X+1}.{Y+1})";
        }

    }

}
