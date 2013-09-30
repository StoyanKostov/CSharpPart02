/// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
/// Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Globalization;

class DateMatch
{
    static void Main(string[] args)
    {
        string inputText = @"Краен срок: 23:59 часа на 31.01.2013.
                             Видео - 22.01.2013.
                             Видео - 23 януари 2013 - Наков.
                             Видео - 23.01.2013 - Наков.
                             Краен срок: 23:59 часа на 03.02.2013.";

        string[] textArray = inputText.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in textArray)
        {
            string wordNoDot = word;
            if (word[word.Length - 1] == '.')
            {
                wordNoDot = word.Substring(0, word.Length - 1);
            }
        }

        foreach (string word in textArray)
        {
            try
            {
                DateTime date = DateTime.ParseExact(word, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string dateCanada = date.ToString("dd/MM/yy", CultureInfo.InvariantCulture);
                Console.WriteLine(dateCanada);
            }
            catch (Exception)
            {
            }
        }
    }
}