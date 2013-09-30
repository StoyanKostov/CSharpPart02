using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

// Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteWordsWithPrefix
{
    private static string RemoveWordsWithPrefixTest(string textInCurrentLine)
    {
        // Create a regular expression that will get words that start with "test" or "Test" and have only symbols digits, latin letters and '_' at the end
        string wordsWithPrefixTest = @"\b[tT]+est[0-9a-zA-Z_]+\b*[\s]*";

        // Remove the matches that were found using the expression above
        string modifiedText = Regex.Replace(textInCurrentLine, wordsWithPrefixTest, "");

        return modifiedText;
    }

    static void Main()
    {
        StreamReader originalFile = new StreamReader("textfile.txt");
        string textInTheFile;

        using (originalFile)
        {
            textInTheFile = originalFile.ReadToEnd();
        }

        string modifiedText = RemoveWordsWithPrefixTest(textInTheFile);

        StreamWriter modifiedFile = new StreamWriter("textfile.txt", false);

        using (modifiedFile)
        {
            modifiedFile.WriteLine(modifiedText);
        }
    }
}
