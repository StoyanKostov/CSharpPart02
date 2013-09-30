using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter first date");
        string date1 = Console.ReadLine();
        int day = int.Parse(date1.Substring(0, date1.IndexOf('.', 0)));
        int index = date1.IndexOf('.', 0);
        int month = int.Parse(date1.Substring(index + 1, 2));
        int index1 = date1.IndexOf('.', index + 1);
        int year = int.Parse(date1.Substring(index1 + 1, 4));
        DateTime a = new DateTime(year, month, day);
        Console.WriteLine("Please enter secound date");
        string date2 = Console.ReadLine();
        int day1 = int.Parse(date2.Substring(0, date1.IndexOf('.', 0)));
        index = date1.IndexOf('.', 0);
        int month1 = int.Parse(date2.Substring(index + 1, 2));
        index1 = date1.IndexOf('.', index + 1);
        int year1 = int.Parse(date2.Substring(index1 + 1, 4));
        DateTime b = new DateTime(year1, month1, day1);

        Console.WriteLine("{0} days.", (b - a).TotalDays < 0 ? (a - b).TotalDays : (b - a).TotalDays);



    }
}

