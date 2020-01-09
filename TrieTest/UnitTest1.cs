using System;
using TrieCS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrieTest
{
    [TestClass]
    public class TrieTest1
    {
        [TestMethod]
        public void TestInstantiation()
        {
            Trie t = new Trie();
        }

        [TestMethod]
        public void TestInstantiationFromFile()
        {
            string path = "TEST-words.txt";
            Trie t = new Trie(path);
        }

        [TestMethod]
        public void TestInstantiationFromArray()
        {
            Trie t = new Trie(new string[] { "CORE", "LINUS" });
        }

        [TestMethod]
        public void TestContainsMethod()
        {
            string[] words = new string[] { "ABBEY", "COLUMN", "ZYGOTE", "MEN" };
            Trie t = new Trie(words);

            foreach (string word in words)
            {
                Assert.IsTrue(t.Contains(word));
            }

            Assert.IsFalse(t.Contains(""));
            Assert.IsFalse(t.Contains("as;dlasdl;"));
            Assert.IsFalse(t.Contains("ABBEYS"));
            Assert.IsFalse(t.Contains("ABBE"));
            Assert.IsFalse(t.Contains("BBEY"));
        }

        public void TestInsertMethod()
        {
            string word = "friend";

            Trie t = new Trie();
            t.Insert(word);

            Assert.IsTrue(t.Contains(word));
        }

        public void TestCaseSensitivity()
        {
            string word = "Friend";

            Trie t = new Trie();
            t.Insert(word);

            Assert.IsFalse(t.Contains(word.ToLower()));
            Assert.IsFalse(t.Contains(word.ToUpper()));
        }
    }
}
