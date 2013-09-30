using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        string word = " " + Console.ReadLine() + " ";
        string text = Console.ReadLine();
        List<string> result = new List<string>();
        string[] separatedText = text.Split('.');
        for (int i = 0; i < separatedText.Length; i++)
        {
            if (separatedText[i].IndexOf(word, 0) != -1)
            {
                result.Add(separatedText[i] + ".");
            }
        }
        foreach (var item in result)
        {
            Console.WriteLine(item.Trim());
        }

    }
}