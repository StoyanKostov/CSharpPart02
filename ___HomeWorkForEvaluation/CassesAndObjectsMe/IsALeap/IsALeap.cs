using System;
using System.Linq;

namespace IsALeap
{
    class IsALeap
    {
        private static void CheckIsALeap(int year, bool isNum)
        {
            if ((year >= 0) && (isNum == true))
            {
                Console.Write("Enter an year: ");
                try
                {
                    isNum = int.TryParse(Console.ReadLine(), out year);
                    bool isLeap = DateTime.IsLeapYear(year);

                    if (isLeap == true)
                    {
                        Console.WriteLine("Entered year is a leap!");
                    }
                    else
                    {
                        Console.WriteLine("Entered year isn't a leap!");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The entered value is incorrect!");
                }
            }
        }

        private static string RestartProgram(int year, bool isNum, string userCoice)
        {
            while (userCoice == "Y")
            {
                Console.WriteLine("Do you want to check another year? (Y/N): ");

                userCoice = Console.ReadLine().ToUpper();

                if (userCoice == "Y")
                {
                    CheckIsALeap(year, isNum);
                }
                else
                {
                    userCoice = "N";
                }
            }
            return userCoice;
        }

        static void Main()
        {
            Console.WriteLine("This program will check if given year is a leap.");
            int year = 0;
            bool isNum = true;

            CheckIsALeap(year, isNum);

            string userCoice = "Y";

            userCoice = RestartProgram(year, isNum, userCoice);           
        }
    }
}
