/* 10. Write a program that extracts from given XML file all the text without the tags. Example:

<?xml version="1.0"?>
<student>
    <name>Pesho</name>
    <age>21</age>
    <interests count="3">
        <interest>Games</interest>
        <interest>C#</interest>
        <interest>Java</interest>
    </interests>
</student>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class RemovesTags
{
    static void Main()
    {
        try
        {
            List<string> textWithoutTags = new List<string>();
            StreamReader textWithTags = new StreamReader(@"C:\Elly-documents\C#\start.TXT");
            using (textWithTags)
            {
                for (int i; (i = textWithTags.Read()) != -1; ) // Read char by char
                {
                    if (i == '>') // check for text between > and <
                    {
                        string text = String.Empty;

                        while ((i = textWithTags.Read()) != -1 && i != '<')
                        {
                            text += (char)i;

                        }
                        if (!String.IsNullOrWhiteSpace(text))
                        {
                            Console.WriteLine(text);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
