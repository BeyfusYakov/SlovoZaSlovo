using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal class TrieNode
    {
        private string word = null;
        private TrieNode[] nodes = new TrieNode[32];

        public void Add(string str, int ind)
        {
            if (str.Length == ind)
            {
                word = str;
                return;
            }
            char currentChar = str[ind];
            int cind = currentChar - 'А';
            if (nodes[cind] == null) nodes[cind] = new TrieNode();
            nodes[cind].Add(str, ind + 1);
        }

        public void FindWordsFunc(Point[,] board, int i, int j, bool[,] usedBoard, HashSet<Answer> ret, List<Point> ListOfPoints)
        {
            if (i < 0 || i >= board.GetLength(0)) return;
            if (j < 0 || j >= board.GetLength(1)) return;
            if (usedBoard[i, j]) return;

            if (word != null)
            {
                int tmpCost = 0;
                int tmpFactor = 1;
                for(int k = 1; k <= ListOfPoints.Count; k++)
                {
                    switch (ListOfPoints[k-1].Factor)
                    {
                        case 0:
                            tmpCost += k;
                            break;
                        case 3: 
                            tmpCost += k*2;
                            break;
                        case 4:
                            tmpCost += k*3;
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
                    ret.Add(new Answer(word, tmpCost* tmpFactor, new List<Point>(ListOfPoints)));
            }
            
            ListOfPoints.Add(board[i, j]);

            usedBoard[i, j] = true;

            char c = board[i,j].Val;
            int ind = c - 'А';

            var node = nodes[ind];
            if (node != null)
            {
                node.FindWordsFunc(board, i - 1, j - 1, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i - 1, j, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i - 1, j + 1, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i, j + 1, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i + 1, j + 1, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i + 1, j, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i + 1, j - 1, usedBoard, ret, ListOfPoints);
                node.FindWordsFunc(board, i, j - 1, usedBoard, ret, ListOfPoints);
            }
            usedBoard[i, j] = false;
            ListOfPoints.RemoveAt(ListOfPoints.Count-1); // переделать в RemoveAt(^1);

        }
    }
}
