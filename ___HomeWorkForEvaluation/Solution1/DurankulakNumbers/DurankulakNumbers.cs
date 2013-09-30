using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> allNumbers = new List<string>(169);

            for (char i = 'A'; i <= 'Z'; i++)
            {
                allNumbers.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'f'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    allNumbers.Add(i.ToString() + j.ToString());
                }
            }

            ulong result = 0;
            int currentNumber = 0;
            string currentSymbolLower = string.Empty;
            char currentSymbolUpper;
            int power = 0;

            if (input.Length > 1)
            {

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    currentSymbolUpper = input[i];
                    if (i != 0)
                    {
                        if (char.IsUpper(input[i - 1]))
                        {
                            currentNumber = allNumbers.IndexOf(currentSymbolUpper.ToString());
                            result += (ulong)currentNumber * (ulong)Math.Pow(168, power);
                            power++;
                        }
                        else
                        {
                            currentSymbolLower = input[i - 1].ToString() + currentSymbolUpper;
                            currentNumber = allNumbers.IndexOf(currentSymbolLower);
                            result += (ulong)currentNumber * (ulong)Math.Pow(168, power);
                            power++;
                            i--;
                        }
                    }
                    else
                    {
                        currentNumber = allNumbers.IndexOf(currentSymbolUpper.ToString());
                        result += (ulong)currentNumber * (ulong)Math.Pow(168, power);
                        break;
                    }
                }
            }
            else
            {
                currentSymbolUpper = input[0];
                currentNumber = allNumbers.IndexOf(currentSymbolUpper.ToString());
                result += (ulong)currentNumber * (ulong)Math.Pow(168, power);
            }
            Console.WriteLine(result);
        }
    }
}
