//100 points

using System;

    class KaspichanNumbers
    {
        static void Main()
        {
            ulong decimalNumber = ulong.Parse(Console.ReadLine());
            string kaspichanNumber = "";
            string lowercase = "abcdefghi";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            if (decimalNumber == 0)
            {
                Console.WriteLine("A");
            }

            for (ulong dividing = decimalNumber; dividing > 0; dividing /= 256)
            {
                string currDigit = "";
                ulong remainder = dividing % 256;
                int low = (int) remainder / 26;
                int up = (int) remainder % 26;

                if (low == 0)
                {
                    currDigit = uppercase[up].ToString();
                }
                else
                {
                    currDigit = lowercase[low - 1].ToString() + uppercase[up];
                }

                kaspichanNumber += currDigit + " ";
            }

            string[] kaspichanNumberDigits = kaspichanNumber.Split(' ');

            for (int i = kaspichanNumberDigits.Length - 1; i >= 0; i--)
            {
                Console.Write(kaspichanNumberDigits[i]);
            }

            Console.WriteLine();

        }
    }

