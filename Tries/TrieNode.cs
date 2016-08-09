namespace Tries
{
    public class TrieNode
    {
        public string Value { get; set; }
        public TrieNode[] ChildNodes { get; set; }

        public TrieNode(short size)
        {
            ChildNodes = new TrieNode[size];
        }
    }
}
