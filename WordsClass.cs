using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordsClass
    {
        private static List<Point> ListOfPoints = new List<Point>();
        public static  HashSet<Answer> FindWords(Point[,] board, TrieNode root)
        {
            var ret = new HashSet<Answer>();
            int row = board.GetLength(0);
            int col = board.GetLength(1);

            var usedMap = new bool[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    root.FindWordsFunc(board, i, j, usedMap, ret, ListOfPoints);
                }
            }

           return ret;
        }
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
                        tmpCost += k * 2;
                        break;
                    case 4:
                        tmpCost += k * 3;
                        break;
                    case 1:
                        tmpCost += k;
                        tmpFactor *= 2;
                        break;
                    case 2:
                        tmpCost += k;
                        tmpFactor *= 3;
                        break;
                }

            }
            return tmpCost * tmpFactor;
        }
    }
}
