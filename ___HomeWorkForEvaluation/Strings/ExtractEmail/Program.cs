using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] split = text.Split(' ');
        foreach (var item in split)
        {
            char[] ch = item.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@')
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}

