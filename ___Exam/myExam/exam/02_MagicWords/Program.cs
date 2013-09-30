using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static void Main(string[] args)
    {
        // Console input
        int lineNumber = int.Parse(Console.ReadLine());
        //string[] inputArray = new string[lineNumber];
        List<string> wordsArray = new List<string>(lineNumber);
        int maxlWordLength = 0;

        for (int i = 0; i < lineNumber; i++)
        {
            string inputWord = Console.ReadLine();
            wordsArray.Add(inputWord);
            if (inputWord.Length > maxlWordLength)
            {
                maxlWordLength = inputWord.Length;
            }
        }

        //main logic
        for (int i = 0; i < lineNumber; i++) // lineNumber
        {
            string currWord = wordsArray[i];
            int currentIndex = currWord.Length % (lineNumber + 1);
            if (currentIndex < 0)
            {
                currentIndex = 0;
            }
            if (currentIndex >= lineNumber)
            {
                currentIndex--;
            }
            wordsArray.Remove(currWord);
            wordsArray.Insert(currentIndex, currWord);
        }

        StringBuilder sb = new StringBuilder();
        // ConsoleOutPut
       
        for (int currChar = 0; currChar < maxlWordLength; currChar++)
        {
            for (int word = 0; word < lineNumber; word++)
            {
                string currWord = wordsArray[word];
                if (currWord.Length > currChar)
                {
                    sb.Append(currWord[currChar]);
                }

            }
        }

        Console.WriteLine(sb.ToString());
    }
}
