using System;
using System.Text;

public class ReverseEachWordChallange
{
    static string ReverseEachWord(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        string[] words = input.Split(' ');
        StringBuilder stringToReturn = new StringBuilder(input.Length);

        foreach (var word in words)
        {
            stringToReturn.Append(Reverse(word) + " ");
        }
        return stringToReturn.ToString();
    }

    static String Reverse(String input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string with no punctuation (or 'exit' to close the console)");
        string userInput = Console.ReadLine();
        while(userInput != "exit")
        {
            Console.WriteLine(ReverseEachWord(userInput));
            Console.WriteLine("Enter a string with no punctuation (or 'exit' to close the console)");
            userInput = Console.ReadLine();
        }
    }
}