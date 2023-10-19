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

        public void FindWordsFunc(Point[,] board, int i, int j, bool[,] usage, HashSet<Answer> ret)
        {
            if (word != null)
            {
                    var tempLst = new List<Point>();
                    for (int k = 0; k < board.GetLength(0); k++)
                    {
                        for (int l = 0; l < board.GetLength(1); l++)
                        {
                            if (usage[k, l])
                                tempLst.Add(board[k, l]);
                        }
                    }
                {
                    ret.Add(new Answer(word, 0, tempLst));
                    
                }

            }
            if (i < 0 || i >= board.GetLength(0)) return;
            if (j < 0 || j >= board.GetLength(1)) return;

            if (usage[i, j]) return;

            usage[i, j] = true;

            char c = board[i,j].Val;
            int ind = c - 'А';

            var node = nodes[ind];
            if (node != null)
            {
                node.FindWordsFunc(board, i + 1, j, usage, ret);
                node.FindWordsFunc(board, i - 1, j, usage, ret);
                node.FindWordsFunc(board, i, j + 1, usage, ret);
                node.FindWordsFunc(board, i, j - 1, usage, ret);
                node.FindWordsFunc(board, i + 1, j + 1, usage, ret);
                node.FindWordsFunc(board, i - 1, j - 1, usage, ret);
                node.FindWordsFunc(board, i + 1, j - 1, usage, ret);
                node.FindWordsFunc(board, i - j, j + 1, usage, ret);
            }

            usage[i, j] = false;
        }
    }
}
