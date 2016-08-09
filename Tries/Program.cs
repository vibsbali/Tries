namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Trie();

            dictionary.Add("a");
            dictionary.Add("an");
            dictionary.Add("and");
            dictionary.Add("bravo");
        }
    }
}
