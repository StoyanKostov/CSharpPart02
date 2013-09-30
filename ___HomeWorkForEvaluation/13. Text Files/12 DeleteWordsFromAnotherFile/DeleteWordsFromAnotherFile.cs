using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

// Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

class DeleteWordsFromAnotherFile
{
    private static MatchCollection ExtractWordsFromText(string fileWithWordsText)
    {
        Regex selectAllWords = new Regex(@"\b\w+\b");
        MatchCollection words = selectAllWords.Matches(fileWithWordsText);

        return words;
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

        // Get the text of the file from which the words should be deleted
        StreamReader fileToDeleteWordsFrom = new StreamReader("textWithRemovedWords.txt");
        string fileToDeleteWordsFromText;

        using (fileToDeleteWordsFrom)
        {
            fileToDeleteWordsFromText = fileToDeleteWordsFrom.ReadToEnd();
        }

        // Delete all words in the array from the text
        StringBuilder modifiedText = new StringBuilder(fileToDeleteWordsFromText);

        foreach (var word in wordsInFile)
        {
            string currentWordToDelete = word.ToString();
            modifiedText.Replace(currentWordToDelete, "");
        }

        // Write the text to the file
        StreamWriter modifiedTextFile = new StreamWriter("textWithRemovedWords.txt");

        using (modifiedTextFile)
        {
            modifiedTextFile.Write(modifiedText);
        }
    }
}