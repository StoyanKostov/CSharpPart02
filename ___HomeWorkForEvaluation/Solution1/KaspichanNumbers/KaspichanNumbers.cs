using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            List<string> allNumbers = new List<string>(256);

            for (char i = 'A'; i <= 'Z'; i++)
            {
                allNumbers.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'i'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    allNumbers.Add(i.ToString() + j.ToString());
                }
            }

            var result = new List<string>();
            ulong reminder = 0;

            if (input == 0)
            {
                Console.Write("A");
                return;
            }

            while (input != 0)
            {
                reminder = input % 256;
                result.Add(allNumbers[(int)reminder].ToString());
                input /= 256;
            }

            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
