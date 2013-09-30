/// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersCount
{
    static void Main(string[] args)
    {
        // Console Input
        Console.WriteLine("Enter text: ");
        string inputText = Console.ReadLine();

        // main logik
        List<char> letters = new List<char>();
        List<int> numbers = new List<int>();
        letters.Add(inputText[0]);
        numbers.Add(1);
        bool check = false;
        for (int i = 1; i < inputText.Length; i++)
        {
            if (Char.IsLetter(inputText[i]))
            {
                for (int j = 0; j < letters.Count; j++)
                {

                    if (inputText[i] == letters[j])
                    {
                        numbers[j]++;
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    letters.Add(inputText[i]);
                    numbers.Add(1);
                }
                check = false;
            }
            else
            {
                continue;
            }
        }
        
        // Console output
        for (int i = 0; i < letters.Count; i++)
        {
            Console.WriteLine("The letter \'{0}\' appears {1} times in the string.", letters[i], numbers[i]);
        }

    }
}