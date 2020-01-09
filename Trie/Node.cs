using System;
using System.Collections.Generic;
using System.Text;

namespace TrieCS
{
    public class Node
    {
        /// <summary>
        /// Indicates whether the current node is the last node of a word
        /// </summary>
        public bool Terminal { get; set; } = false;

        public Dictionary<char, Node> Children { get; set; } = new Dictionary<char, Node>();
    }
}
