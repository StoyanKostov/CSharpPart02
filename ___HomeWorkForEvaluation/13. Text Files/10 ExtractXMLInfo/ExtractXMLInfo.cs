using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

// Write a program that extracts from given XML file all the text without the tags

class ExtractXMLInfo
{
    private static string RemoveTagsFromText(string textInCurrentLine)
    {
        StringBuilder extractedText = new StringBuilder();
        extractedText.Append(textInCurrentLine);

        // Check if there are tags in the line. If yes - remove the text between the tags and the tags
        if (textInCurrentLine.IndexOf("<") != 1 && textInCurrentLine.IndexOf(">") != -1)
        {
            int startIndexInText = textInCurrentLine.IndexOf("<");
            int endIndexInText = textInCurrentLine.IndexOf(">", startIndexInText);

            // We must know how many chars we have removed, so we can calculate the position of the elements to remove in the StringBuilder
            int lengthOfRemovedChars = 0;

            while (startIndexInText != -1)
            {
                int lengthOfCurrentTag = endIndexInText - startIndexInText + 1;

                extractedText.Remove(startIndexInText - lengthOfRemovedChars, lengthOfCurrentTag);
                lengthOfRemovedChars += lengthOfCurrentTag;

                startIndexInText = textInCurrentLine.IndexOf("<", endIndexInText);

                if (startIndexInText != -1)
                {
                    endIndexInText = textInCurrentLine.IndexOf(">", startIndexInText);
                }
                else
                {
                    break;
                }
            }
        }

        return extractedText.ToString();
    }

    static void Main()
    {
        StreamWriter extractedText = new StreamWriter("extractedText.txt", false);
        
        using (extractedText)
        {
            StreamReader xmlFile = new StreamReader("sampleXML.txt");
            
            using (xmlFile)
            {
                string textInCurrentLine = xmlFile.ReadToEnd();
                extractedText.WriteLine(RemoveTagsFromText(textInCurrentLine));
            }
        }
    }
}
