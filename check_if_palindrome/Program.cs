class Program
{
    static void Main()
    {
        Console.WriteLine("please enter a word to check if it's a palindrome:");
        string userInput = Console.ReadLine();
        int i = 0;
        int j = userInput.Length - 1;

        while (i < j)
        {
            if (userInput[i] != userInput[j])
            {
                Console.WriteLine("your entered word isn't a palindrome.");
                return;
            }
            i++;
            j-= 1;
        }
        Console.WriteLine("The entered word is a palindrome!");
    }
}
