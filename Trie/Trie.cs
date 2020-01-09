using System;
using System.Collections.Generic;
using System.IO;


namespace TrieCS
{
    public class Trie
    {
        public Node root = new Node();

        public Trie() { }

        public Trie(string filepath)
        {
            foreach (string word in File.ReadLines(filepath))
            {
                Insert(word);
            }
        }

        public Trie(IEnumerable<string> words)
        {
            foreach (string word in words)
            {
                Insert(word);
            }
        }

        public void Insert(string word)
        {
            Node current = root;
            Node next;

            int i = 0;
            char letter;

            while (i < word.Length)
            {
                letter = word[i];
                if (!current.Children.TryGetValue(letter, out next))
                {
                    break;
                }

                current = next;
                i += 1;
            }

            while (i < word.Length)
            {
                letter = word[i];
                current.Children.Add(letter, new Node());

                current = current.Children[letter];
                i += 1;
            }

            current.Terminal = true;
        }

        /// <summary>
        /// Checks whether the word is in the Trie. Case-sensitive
        /// </summary>
        /// <param name="word">Word to check</param>
        /// <returns></returns>
        public bool Contains(string word)
        {
            char letter;
            Node node = root;

            for (int i = 0; i < word.Length; i++)
            {
                letter = word[i];

                if (!node.Children.TryGetValue(letter, out node))
                {
                    return false;
                }
            }

            if (!node.Terminal)
            {
                return false;
            }

            return true;
        }
    }
}
