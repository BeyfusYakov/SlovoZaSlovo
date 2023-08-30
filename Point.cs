using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{

        public record Point
        {
            private int x { get; set; }
            private int y { get; set; }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    
}
