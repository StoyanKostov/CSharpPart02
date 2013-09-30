using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _9GagNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] allNumbers = 
            {
                "-!",
                "**",
                "!!!",
                "&&",
                "&-",
                "!-",
                "*!!!",
                "&*!",
                "!!**!-"
            };

            string currentNumber = string.Empty;
            List<BigInteger> resultInNineSystem = new List<BigInteger>();
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (currentNumber.Length == 0)
                {
                    currentNumber = input[i].ToString();
                }
                else
                {
                    currentNumber += input[i].ToString();
                    if (allNumbers.Contains(currentNumber))
                    {
                        for (int j = 0; j < allNumbers.Length; j++)
                        {
                            if (currentNumber == allNumbers[j])
                            {
                                index = j;
                            }
                        }
                        resultInNineSystem.Add(index);
                        index = 0;
                        currentNumber = string.Empty;
                    }
                }
            }

            int power = resultInNineSystem.Count - 1;
            BigInteger result = 0;

            for (int i = 0; i < resultInNineSystem.Count; i++)
            {
                result += resultInNineSystem[i] * CalculatePowerOfNine(power);
                power--;
            }
            Console.WriteLine(result);
        }

        static BigInteger CalculatePowerOfNine(int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 9;
            }
            return result;
        }
    }
}
