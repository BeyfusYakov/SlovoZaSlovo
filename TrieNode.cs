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

            if (word != null) ret.Add(new Answer(word, WordsClass.CalkCost(ListOfPoints), new List<Point>(ListOfPoints)));
            
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
            ListOfPoints.RemoveAt(ListOfPoints.Count-1); 

        }
    }
}
