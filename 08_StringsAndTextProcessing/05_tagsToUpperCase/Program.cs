/// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TagsToUpperCase
{
    // We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

    static void Main(string[] args)
    {
        // Console input
        Console.WriteLine("Enter string: ");
        //string inputStr = Console.ReadLine();
        string inputStr = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        //string inputStr = "We are living in a yellow submarine. We don't have anything else.";

        // Main Logic
        int startIndex = inputStr.IndexOf("<upcase>");
        if (startIndex > -1) // Cheks if there is such tag at all
        {
            int endIndex = inputStr.IndexOf("</upcase>", startIndex);
            string upperSubString = inputStr.Substring(startIndex + 8, endIndex - (startIndex + 8));
            inputStr = inputStr.Replace("<upcase>" + upperSubString + "</upcase>", upperSubString.ToUpper());

            while (true)
            {
                startIndex = inputStr.IndexOf("<upcase>", startIndex + 1);
            
                if (startIndex < 0) // When there are no more tags that follow loop breaks
                {
                    break;
                }
            
                endIndex = inputStr.IndexOf("</upcase>", startIndex + 1);
                upperSubString = inputStr.Substring(startIndex + 8, endIndex - (startIndex + 8));
                inputStr = inputStr.Replace("<upcase>" + upperSubString + "</upcase>", upperSubString.ToUpper());
            }
        }
        // Console output
        Console.WriteLine(inputStr);
    }
}