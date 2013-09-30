using System;

using System.Text;


class MultiverseCommunicator
{
    static void Main(string[] args)
    {
        string num13 = string.Empty;
        
        // Console Input
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i += 3)
        {
            string sub = input.Substring(i, 3);

            switch (sub)
            {
                case "CHU":
                case "chu":
                    num13 = "0";
                    break;
                case "TEL":
                case "tel":
                    num13 = "1";
                    break;
                case "OFT":
                case "oft":
                    num13 = "2";
                    break;
                case "IVA":
                case "iva":
                    num13 = "3";
                    break;
                case "EMY":
                case "emy":
                    num13 = "4";
                    break;
                case "VNB":
                case "vnb":
                    num13 = "5";
                    break;
                case "POQ":
                case "poq":
                    num13 = "6";
                    break;
                case "ERI":
                case "eri":
                    num13 = "7";
                    break;
                case "CAD":
                case "cad":
                    num13 = "8";
                    break;
                case "K-A":
                case "k-a":
                    num13 = "9";
                    break;
                case "IIA":
                case "iia":
                    num13 = "A";
                    break;
                case "YLO":
                case "ylo":
                    num13 = "B";
                    break;
                case "PLA":
                case "pla":
                    num13 = "C";
                    break;
            }

            sb.Append(num13);
        }

        // Console Output
        //Console.WriteLine(to13Base(sb.ToString()));
        Console.WriteLine(sb.ToString());
    }

    public static int to13Base(string input)
    { 
        int result = 0;
        int toBase = 13;
        int digit = 0;
        int Pow = input.Length - 1;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default: digit = int.Parse(Convert.ToString(input[i]));
                    break;
            }

            result += digit * (int)Math.Pow(toBase, Pow);
            Pow -= 1;
        }

        return result;
    }
}

