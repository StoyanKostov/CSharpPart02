using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        string getDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(getDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
