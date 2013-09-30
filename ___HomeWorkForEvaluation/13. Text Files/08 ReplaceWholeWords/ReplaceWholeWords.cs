using System;
using System.IO;
using System.Text;

// Modify the solution of the previous problem to replace only whole words (not substrings).

class ReplaceWholeWords
{
    private static string ReplaceSubstringsInText(string textInFile)
    {
        StringBuilder replacedText = new StringBuilder();
        replacedText.Append(textInFile);

        replacedText.Replace(" start ", " finish ");
        replacedText.Replace("start ", "finish ");
        replacedText.Replace(" start", " finish");

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
