class Program
{
    static void Main()
    {
        Console.WriteLine("please enter a word to check if it's a palindrome:");
        string userInput = Console.ReadLine();
        int i = 0;
        int j = userInput.Length - 1;

        for (i = 0; i < j;)
        {
            if (userInput[i] == j)
            {
                i++;
                j -= 1;
            }
            else
            {
                Console.WriteLine("your entered word isn't a palindrome.");
            }
        }
        Console.WriteLine("your word is a palindrome!");
    }
}
