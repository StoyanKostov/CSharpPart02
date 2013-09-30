/// In Kaspichan we have a special way to write numbers. We use the following 256 digits
/// Your task is to write a program to convert a decimal number into its corresponding representation in Kaspichan.
/// Input -> The input data consists of a single integer number.
/// Output -> The output data consists of a single text line holding the result and should be printed at the console.

using System;
using System.Collections.Generic;

 class KaspichanNumbers
 {
     static void Main()
     {
         string result = "";

         // Consol Input
         ulong inputNumber = ulong.Parse(Console.ReadLine());

         // Create Kaspichan Digits
         List<string> KaspichanDigits = new List<string>();

         for (char i = 'A'; i <= 'Z'; i++)
         {
             KaspichanDigits.Add(i.ToString());
         }

         for (char i = 'a'; i <= 'i'; i++)
         {
             for (char j = 'A'; j <= 'Z'; j++)
             {
                 KaspichanDigits.Add(i.ToString() + j.ToString());
             }
         }

         // Main Logic
         if (inputNumber == 0)
         {
             result = "A";
         }
         else
         {
             while (inputNumber != 0)
             {
                 result = KaspichanDigits[(int)inputNumber % 256] + result;
                 inputNumber = inputNumber / 256;
             }
         }

         // Console Output
         Console.WriteLine(result);
     }
 }