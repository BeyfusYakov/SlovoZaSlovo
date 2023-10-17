using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordsClassTrie
    {
        public static  HashSet<Answer> FindWords(Point[,] board, TrieNode root)
        {
            var ret = new HashSet<Answer>();
            var rootTrie = root;
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
    }
}
