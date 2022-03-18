class Program
{
    static void Main()
    {
        // Group the unique words of same length in a given sentence, sort the groups
        // in increasing order and display the groups, the word count and the words of that length.

        string str = "The “C# Professional” course includes the topics I discuss in my CLR via C# " +
                     "book and teaches how the CLR works thereby showing you how to develop " +
                     "applications and reusable components for the.NET Framework. ";


        var array = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();


        var words = from word in array
                    orderby word.Length
                    group word by word.Length;

        foreach (var group in words)
        {
            Console.WriteLine($"Words of length = {group.Key}, Count { group.Count() }");

            foreach (var word in group)
            {
                Console.WriteLine(word);
            }
        }
        Console.ReadLine();
    }
}