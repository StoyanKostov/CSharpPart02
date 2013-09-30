using System;
using System.Collections.Generic;


class Slides
{
    static void Main()
    {
        //Consol input
        int[] cubeSides = Array.ConvertAll<string, int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        string[, ,] cube = new string[cubeSides[0], cubeSides[1], cubeSides[2]]; // W H D

        string[] foo = { "(S L)(E)(S L) | (S L)(S R)(S L) | (B)(S F)(S L)",
                         "(S B)(S F)(E) | (S B)(S F)(T 1 1)  | (S L)(S g)(B)",
                           "(S FL)(S FL)(S FR) | (S FL)(S FL)(S FR) | (S F)(S BR)(S FR)"};

        for (int height = 0; height < cube.GetLength(1); height++)
        {
            //string[] cubes = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            string[] cubes = foo[height].Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            for (int depth = 0; depth < cube.GetLength(2); depth++)
            {
                string[] currentLayer = cubes[depth].Split(new string[] { "(", ")", ")(" }, StringSplitOptions.RemoveEmptyEntries);

                for (int width = 0; width < cube.GetLength(0); width++)
                {
                    cube[height, depth, width] = currentLayer[width];
                }
            }
        }

        int cubeHeight = cube.GetLength(1);

        string[] inpuBall = Console.ReadLine().Split();
        //int ballW = int.Parse(inpuBall[0]);
        //int ballD = int.Parse(inpuBall[1]);
        //int heigth = 0;
        int[] ballCoodinates = { int.Parse(inpuBall[0]), int.Parse(inpuBall[1]), 0 };
        //string currentCell = cube[ heigth, ballW, ballD ];
        string currentCell = cube[ballCoodinates[2], ballCoodinates[1], ballCoodinates[0]];

        while (true)
        {
            if (currentCell[0] == 'B')
            {
                Console.WriteLine("No");
                Console.WriteLine("{0} {1} {2}", ballCoodinates[0], ballCoodinates[1], ballCoodinates[2]);
                break;
            }

            else if (ballCoodinates[2] == cube.GetLength(1) - 1)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0} {1} {2}", ballCoodinates[0], ballCoodinates[1], ballCoodinates[2]);
                break;
            }

            else if (currentCell[0] == 'S')
            {
                switch (currentCell)
                {
                    case "S L": ballCoodinates[0] -= 1;
                        break;
                    case "S R": ballCoodinates[0] += 1;
                        break;
                    case "S F": ballCoodinates[1] -= 1;
                        break;
                    case "S B": ballCoodinates[1] += 1;
                        break;
                    case "S FL": ballCoodinates[1] -= 1; 
                                 ballCoodinates[0] -= 1;
                        break;
                    case "S BL": ballCoodinates[1] += 1; 
                                 ballCoodinates[0] -= 1;
                        break;
                    case "S FR": ballCoodinates[1] -= 1;
                                 ballCoodinates[0] += 1;
                        break;
                    case "S BR": ballCoodinates[1] += 1;
                                 ballCoodinates[1] += 1;
                        break;
                }
                ballCoodinates[2] += 1;
            }

            else if (currentCell[0] == 'T')
            {
                ballCoodinates[0] = int.Parse(currentCell[2].ToString());
                ballCoodinates[1] = int.Parse(currentCell[4].ToString());
            }

            else if (currentCell[0] == 'E')
            {
                ballCoodinates[2] += 1;
            }

 
            currentCell = currentCube(ballCoodinates, cube);
        }
    }

    public static string currentCube(int[] coordinates, string[, ,] cube)
    {
        string calculatedCube = cube[coordinates[2], coordinates[1], coordinates[0]];
        return calculatedCube;
    }
}