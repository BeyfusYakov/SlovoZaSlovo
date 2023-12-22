using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class FactorValueClass
    {
        public readonly int Id;
        public readonly string Name;
        public readonly Color ColorValue;

        public FactorValueClass(int id, string name, Color colorValue)
        {
            Id = id;
            Name = name;
            ColorValue = colorValue;
        }
    }

    internal static class FactorValueContainer 
    {
        private static int CurInd = 0;

        internal static readonly List<FactorValueClass> FactorProp = new List<FactorValueClass>  
        {
            new FactorValueClass(0, string.Empty, Color.Black),
            new FactorValueClass(1, "С3", Color.Blue),
            new FactorValueClass(2, "С2", Color.Red),
            new FactorValueClass(3, "x3", Color.Blue),
            new FactorValueClass(4, "x2", Color.Red)
        };

        public static FactorValueClass Next()
        {
            if (CurInd + 1 < FactorProp.Count) 
                CurInd++;
            else
                CurInd = 0;
            return FactorProp[CurInd];
        }

        public static FactorValueClass Prev()
        {
            if (CurInd - 1 >= 0)
                CurInd--;
            else
                CurInd = FactorProp.Count-1;
            return FactorProp[CurInd];
        }
    }
}
