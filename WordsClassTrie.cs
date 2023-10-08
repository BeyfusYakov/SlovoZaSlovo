using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordsClassTrie
    {
        public static  List<string> FindWords(char[][] board, TrieNode root)
        {
            var ret = new HashSet<string>();
            var rootTrie = root; 


            var usageMap = new bool[board.Length, board[0].Length];

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    root.FindWords(board, i, j, usageMap, ret);
                }
            }

           return ret.ToList();
           
        }
    }
}
