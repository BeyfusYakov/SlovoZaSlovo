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
        // public int X { get => x; set => x = value; }
        public readonly int Y;
        //  public int Y { get => y; set => y = value; }
        public readonly char Val;
        // public char Val { get => val; set => val = value; }
        public readonly int Factor;
      //  public int Factor { get => factor; set => factor = value; }
        public Point(int x, int y, char val, int factor = 0)
        {
            this.X = x;
            this.Y = y;
            this.Val = val;
            this.Factor = factor;
        }
        public override string ToString()
        {
            return $"{X}.{Y} - {Val}";
        }

    }

}
