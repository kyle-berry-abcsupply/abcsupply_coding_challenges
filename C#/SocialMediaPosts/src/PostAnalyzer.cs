namespace SocialMediaPost
{
    public class PostAnalyzer
    {
        private readonly char[] _wordDelimiters = { ' ', '!', '.', ',', '*', '-', '?' };
        private readonly string _post;

        // TODO: Add your private fields here!

        public PostAnalyzer(string post)
        {
            _post = post;
        }

        public void ProcessPost()
        {
            // TODO: Your Code Here!
        }

        // Returns the total number of distinct words
        public int GetDistinctWordCount()
        {
            return 0; // TODO: Your Code Here!
        }

        // Determine how many times a word appears in the post, given a word
        public int GetIndividualWordCount(string word)
        {
            return 0; // TODO: Your Code Here!
        }
    }
}