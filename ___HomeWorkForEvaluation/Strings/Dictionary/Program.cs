using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter how many words:");
        IDictionary<string, string> dic = new Dictionary<string, string>();
        int wordsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < wordsCount; i++)
        {
            Console.WriteLine("Enter a word hit Enter and then the definition of that word: ");
            string word = Console.ReadLine();
            string definition = Console.ReadLine();
            dic.Add(word, definition);
        }
        Console.WriteLine("Now enter a word to search in the dictonary:");
        string word1 = Console.ReadLine();
        string result = string.Empty;
        dic.TryGetValue(word1, out  result);
        Console.WriteLine("-" + result);
    }
}

