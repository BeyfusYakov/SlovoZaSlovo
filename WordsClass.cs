using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordsClass
    {
        public static int CalcCost(List<Point> ListOfPoints)
        {
            int tmpCost = 0;
            int tmpFactor = 1;
            for (int k = 1; k <= ListOfPoints.Count; k++)
            {
                switch (ListOfPoints[k - 1].Factor)
                {
                    case 0:
                        tmpCost += k;
                        break;
                    case 3:
                        tmpCost += k * 3;
                        break;
                    case 4:
                        tmpCost += k * 2;
                        break;
                    case 1:
                        tmpCost += k;
                        tmpFactor *= 3;
                        break;
                    case 2:
                        tmpCost += k;
                        tmpFactor *= 2;
                        break;
                }

            }
            return tmpCost * tmpFactor;
        }
    }
}
