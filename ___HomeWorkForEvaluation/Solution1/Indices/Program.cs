using System;
using System.Text;


namespace Indices
{
    class Program
    {
        static void Main()
        {
            long n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            bool[] visited = new bool[n];
            int startCycleIndex = -1;
            int currentPossition = 0;

            var processedFields = new StringBuilder();

            while (true)
            {
                if (visited[currentPossition])
                {
                    startCycleIndex = currentPossition;
                    break;
                }
                visited[currentPossition] = true;
                processedFields.Append(currentPossition);
                processedFields.Append(' ');
                currentPossition = arr[currentPossition];
                if (currentPossition >= arr.Length || currentPossition < 0)
                {
                    break;
                }
            }
            if (startCycleIndex != -1)
            {
                int index = processedFields.ToString().IndexOf(" " + startCycleIndex + " ".ToString());
                if (index < 0)
                {
                    processedFields.Insert(0, '(');
                }
                else
                {
                    processedFields[index] = '(';
                }
                processedFields[processedFields.Length - 1] = ')';
            }
            Console.WriteLine(processedFields.ToString().Trim());
        }

    }
}
