///Write methods that calculate the surface of a triangle by given:
///- Side and an altitude to it; 
///- Three sides; 
///- Two sides and an angle between them. 

using System;
using System.Collections.Generic;

class SurfaceTriangle
{
    private static double TriangleArea(int a, int b, int c, int anlge, int altitude)
    {
        if ((a != 0) && (b != 0) && (c != 0)) // Input 3 sides
        {
            double p = ((a + b + c) / 2);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        else if (anlge != 0) // Input 2 sides and angle
        {
            double pi = Math.PI;
            double sin = Math.Sin((anlge * pi) / 180);
            return ((a * b * sin) / 2);
        }
        else if (altitude != 0) // Input 1 sides and altitude
        {
            return ((a * altitude) / 2);
        }
        return 0; // If input error
    }

    static void Main(string[] args)
    {
        // Consol Input
        Console.WriteLine("Write methods that calculate the surface \n- Side and an altitude to it\n- Three sides\n- Two sides and an angle between them.");
        Console.WriteLine("Enter triangle proparties");

        int a = 0;
        Console.Write("Enter side a: ");
        string inputA = Console.ReadLine();
        if (int.TryParse(inputA, out a))
        {
            // Do nothing
        }

        int b = 0;
        Console.Write("Enter side b: ");
        string inputB = Console.ReadLine();
        if (int.TryParse(inputB, out b))
        {
            // Do nothing
        }
       
        int c = 0;
        Console.Write("Enter side c: ");
        string inputC = Console.ReadLine();
        if (int.TryParse(inputC, out c))
        {
            // Do nothing
        }
       
        int anlge = 0;
        Console.Write("Enter anlge: ");
        string inputAnlge = Console.ReadLine();
        if (int.TryParse(inputAnlge, out anlge))
        {
            // Do nothing
        }
       
        int altitude = 0;
        Console.Write("Enter altitude: ");
        string inputAltitude = Console.ReadLine();
        if (int.TryParse(inputAltitude, out altitude))
        {
            // Do nothing
        }

        // Consol output
        Console.WriteLine("Tiangle surface is {0}", TriangleArea( a, b, c, anlge, altitude));
    }
}
