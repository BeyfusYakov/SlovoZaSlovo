using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class FactorValueClass
    {
        public enum FactorValue
        {
            None = 0,
            C2,
            C3,
            x2,
            x3
        }
        private FactorValue factor;

        interface IFactorIterator
        {
            bool HasNext();
            FactorValue Next();
        }



    }
}
