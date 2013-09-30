using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    private static void FillArrayWithDigits(string[] array)
    {
        int element = 0;
        for (char i = 'A'; i <= 'Z'; i++, element++)
        {
            array[element] = i.ToString();
        }

        for (char i = 'a'; i <= 'i'; i++)
        {

            for (char j = 'A'; j <= 'Z'; j++, element++)
            {
                array[element] = (i.ToString() + j.ToString());
                if (element == 255)
                {
                    break;
                }
            }
            
   
        }
    }

    static void Main()
    {
        string[] digits = new string[256];
        FillArrayWithDigits(digits);

        ulong num = ulong.Parse(Console.ReadLine());

        string kaspichanNum = String.Empty;
        if (num == 0)
        {
            kaspichanNum = "A";
        }
        while (num != 0)
        {
            kaspichanNum = digits[(int)(num % 256)] + kaspichanNum;  
            num /= 256;
        }
        Console.WriteLine(kaspichanNum);
    }

    
}
