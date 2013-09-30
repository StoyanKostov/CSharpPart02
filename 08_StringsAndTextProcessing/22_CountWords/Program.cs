/// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some text: ");
        string inputText = Console.ReadLine();
        string[] allWordsArr = inputText.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> rechnik = new Dictionary<string, int>();

        foreach (var word in allWordsArr)
        {
            if (rechnik.ContainsKey(word))
            {
                rechnik[word] = rechnik[word] + 1;
            }
            else //(!rechnik.ContainsKey(word))
            {
                rechnik.Add(word, 1);
            }
        }

        foreach (var word in rechnik)
        {
            Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
        }
    }
}