using System;
using System.Text;

class Program
{
    static void Main()
    {

        string cipher = Console.ReadLine();
        string str = Console.ReadLine();


        EncoderDecoder(EncoderDecoder(str, cipher), cipher);
    }

    static string EncoderDecoder(string message, string key)
    {
        var strBuilder = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            strBuilder.Append((char)(message[i] ^ key[i % key.Length]));
        }
        Console.WriteLine(strBuilder.ToString());
        return strBuilder.ToString();
    }
}

