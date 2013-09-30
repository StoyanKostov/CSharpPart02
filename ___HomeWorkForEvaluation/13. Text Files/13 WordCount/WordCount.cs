using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

/* Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. 
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
 * Handle all possible exceptions in your methods */

class WordCount
{
    private static MatchCollection ExtractWordsFromText(string fileWithWordsText)
    {
        Regex selectAllWords = new Regex(@"\b\w+\b");
        MatchCollection words = selectAllWords.Matches(fileWithWordsText);
       
        return words;
    }

    private static List<string> RemoveDuplicateMatches(MatchCollection wordsInFile)
    {
        List<string> uniqueWords = new List<string>();

        foreach (var word in wordsInFile)
        {
            string currentWord = word.ToString();

            bool stringIsUnique = true;

            for (int index = 0; index < uniqueWords.Count; index++)
            {
                if (currentWord == uniqueWords[index])
                {
                    stringIsUnique = false;
                    break;
                }
            }

            if (stringIsUnique)
            {
                uniqueWords.Add(currentWord);
            }
        }

        return uniqueWords;
    }

    private static int ReturnNumberOfMatches(string word, string wordsInFile)
    {
        int count = 0;
        int startIndex = 0;
        int index = wordsInFile.IndexOf(word, startIndex);

        while (index != -1)
        {
            count++;
            startIndex = index + 1;
            index = wordsInFile.IndexOf(word, startIndex);
        }

        return count;
    }

    static void Main()
    {
        // Get the text from the file with the words to be deleted from the other text file
        StreamReader fileWithWords = new StreamReader("words.txt");
        string fileWithWordsText;

        using (fileWithWords)
        {
            fileWithWordsText = fileWithWords.ReadToEnd();
        }

        // Extract the words in the file into a collection
        MatchCollection wordsInFile = ExtractWordsFromText(fileWithWordsText);

        // Remove all duplicates from the matchCollection and put the words in a list
        List<string> uniqueWords = RemoveDuplicateMatches(wordsInFile);

        // Get the text from the test.txt
        StreamReader fileWithWordsToSearchFrom = new StreamReader("test.txt");
        string wordsToSearchFrom;

        using (fileWithWordsToSearchFrom)
        {
            wordsToSearchFrom = fileWithWordsToSearchFrom.ReadToEnd();
        }

        // Find how many times does a word appear in the test.txt file and put the result in a two-dimentional array
        string[,] unsortedResults = new string[2, uniqueWords.Count];
        for (int index = 0; index < uniqueWords.Count; index++)
        {
            int currentNumberOfMatches = ReturnNumberOfMatches(uniqueWords[index], wordsToSearchFrom);
            unsortedResults[0, index] = currentNumberOfMatches.ToString();
            unsortedResults[1, index] = uniqueWords[index];
        }

        // Put the number of occurances into a list and sort it
        List<int> numberOfOccurrences = new List<int>();

        for (int index = 0; index <= unsortedResults.GetLength(0); index++)
        {
            numberOfOccurrences.Add(Convert.ToInt32(unsortedResults[0, index]));
        }

        numberOfOccurrences.Sort();

        // Put the strings into the result.txt file by using the sorted number of occurances
        StreamWriter sortedWordsFile = new StreamWriter("result.txt");

        using (sortedWordsFile)
        {
            for (int occurrenceIndex = numberOfOccurrences.Count - 1; occurrenceIndex >= 0; occurrenceIndex--)
            {
                for (int wordsIndex = 0; wordsIndex <= unsortedResults.GetLength(0); wordsIndex++)
                {
                    if (numberOfOccurrences[occurrenceIndex] == Convert.ToInt32(unsortedResults[0, wordsIndex]))
                    {
                        sortedWordsFile.WriteLine(unsortedResults[1, wordsIndex]);
                    }
                }
            }
        }
    }
}
