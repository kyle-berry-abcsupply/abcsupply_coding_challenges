namespace SocialMediaPost
{
    /*
     * A social media company needs to analyze posts.
     * Example: "If a walk across the park takes 5 minutes, and a walk to the grocery store takes 10 minutes."
     * Your job is to implement the following method:
     * 
     * - GetIndividualWordCount(string word): Get the word count for the input word (the example above has 2 occurrences of the word "walk")
     * 
     * - GetDistinctWordCount(): Get the total number of distinct words (the example above has 14 distinct words)
     * 
     * - processPost(): Implement an algorithm to process the post into a data structure

     * Helpful Hints:
     * - Think about what data structure to store the post so that it is easy to determine the distinct word count and the individual word counts
     * - The wordDelimiters are already provided
     */
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