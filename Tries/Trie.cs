using System;

namespace Tries
{
    public class Trie
    {
        private const short Radix = 256;
        public int Count { get; private set; }

        private readonly TrieNode root = new TrieNode(Radix);

        public void Add(string word)
        {
            AddRecursively(root, word, 0);
        }

        private void AddRecursively(TrieNode trieNode, string word, int index)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new InvalidOperationException("Word to be added cannot be blank");
            }

            if (trieNode == null)
            {
                throw new ArgumentNullException(nameof(trieNode));
            }

            var character = word[index];

            if (trieNode.ChildNodes[character] == null)
            {
                trieNode.ChildNodes[character] = new TrieNode(Radix);
            }

            if (word.Length - 1 == index)
            {
                trieNode.ChildNodes[character].Value = word;
                return;
            }

            AddRecursively(trieNode.ChildNodes[character], word, ++index);
        }
    }
}