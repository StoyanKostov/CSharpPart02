//100 points

using System;

    class JoroTheRabbit
    {
        static void Main()
        {
            
                string input = Console.ReadLine();//"1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0"; //
              //  string input = "1, 1, 1"; 
               // string input = "1, -2, -3, 4, -5, 6, -7, -8";
                int[] circle = ReadingInput(input);
                int maxPositionsVisited = 0;

                for (int start = 0; start < circle.Length; start++)
                {
                    for (int step = 1; step < circle.Length; step++)
                    {
                        int currNum = circle[start];
                        int positionVisited = 1;

                        for (int cycle = start + step; true; cycle+=step)
                        {

                            if (cycle >= circle.Length)
                            {
                                cycle -= circle.Length;
                            }

                            if (circle[cycle] > currNum)
                            {
                                currNum = circle[cycle];
                                positionVisited++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (maxPositionsVisited < positionVisited)
                        {
                            maxPositionsVisited = positionVisited;
                        }
                    }


                }

                Console.WriteLine(maxPositionsVisited);
            

        }

        private static int[] ReadingInput(string input)
        {
            string[] valleyString = input.Split(',');
            int[] valley = new int[valleyString.Length];

            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(valleyString[i]);
            }

            return valley;
        }
    }

