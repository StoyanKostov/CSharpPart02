using System;
using System.IO;
using System.Text;

/* Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
Ensure it will work with large files (e.g. 100 MB) */

class ReplaceSubstrings
{
    private static string ReplaceSubstringsInText(string textInFile)
    {
        StringBuilder replacedText = new StringBuilder();
        replacedText.Append(textInFile);
        replacedText.Replace("start", "finish");

        return replacedText.ToString();
    }

    static void Main()
    {
        string replacedText;

        StreamReader textFileOriginal = new StreamReader("textfile.txt");
        
        using (textFileOriginal)
        {
            string textInFile = textFileOriginal.ReadToEnd();
            replacedText = ReplaceSubstringsInText(textInFile);
        }

        StreamWriter textFileReplaced = new StreamWriter("textfile.txt");

        using (textFileReplaced)
        {
            textFileReplaced.Write(replacedText);
        }
    }
}
    
