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
        private static List<Point> ListOfPoints = new List<Point>();

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

        public static HashSet<Answer> FindWords(Point[,] board, TrieNode root)
        {
            var ret = new HashSet<Answer>();
            int row = board.GetLength(0);
            int col = board.GetLength(1);

            var usedMap = new bool[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    root.FindWordsFunc(board, i, j, usedMap, ret);
                }
            }

            return ret;
        }

        public void FindWordsFunc(Point[,] board, int i, int j, bool[,] usedBoard, HashSet<Answer> ret)
        {
            if (i < 0 || i >= board.GetLength(0)) return;
            if (j < 0 || j >= board.GetLength(1)) return;
            if (usedBoard[i, j]) return;

            if (word != null) ret.Add(new Answer(word, WordsClass.CalcCost(ListOfPoints), new List<Point>(ListOfPoints)));
            
            ListOfPoints.Add(board[i, j]);
            usedBoard[i, j] = true;
            char c = board[i,j].Val;
            int ind = c - 'А';
            var node = nodes[ind];
            if (node != null)
            {
                node.FindWordsFunc(board, i - 1, j - 1, usedBoard, ret);
                node.FindWordsFunc(board, i - 1, j, usedBoard, ret);
                node.FindWordsFunc(board, i - 1, j + 1, usedBoard, ret);
                node.FindWordsFunc(board, i, j + 1, usedBoard, ret);
                node.FindWordsFunc(board, i + 1, j + 1, usedBoard, ret);
                node.FindWordsFunc(board, i + 1, j, usedBoard, ret);
                node.FindWordsFunc(board, i + 1, j - 1, usedBoard, ret);
                node.FindWordsFunc(board, i, j - 1, usedBoard, ret);
            }
            usedBoard[i, j] = false;
            ListOfPoints.RemoveAt(ListOfPoints.Count-1); 

        }
    }
}
