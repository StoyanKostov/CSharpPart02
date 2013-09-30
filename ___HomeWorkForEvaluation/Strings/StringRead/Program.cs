using System;
using System.Text;

class Program
{
    static void Main()
    {

        string str = Console.ReadLine();
        var strBuilder = new StringBuilder(str);

        if (strBuilder.Length < 20)
        {
            for (int i = strBuilder.Length; i < 20; i++)
            {
                strBuilder.Append('*');
            }
        }
        Console.WriteLine(strBuilder.ToString());
    }
}

