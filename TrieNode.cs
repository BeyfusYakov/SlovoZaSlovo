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
            var c = str[ind];
            var cind = c - 'А';
            if (nodes[cind] == null) nodes[cind] = new TrieNode();
            nodes[cind].Add(str, ind + 1);
        }
    }
}
