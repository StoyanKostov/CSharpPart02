using System;

class SurfaceOfTriangle
{
    private static void MenuSelectMethod()
    {
        int method = 0;

        while ((method == 0) || (method == 1) || (method == 2) || (method == 3))
        {
            Console.Write("Select a preferred method(1,2 or 3): ");
            method = int.Parse(Console.ReadLine());
            if (method == 1)
            {
                Console.WriteLine("The surface of triangle is: {0:f2}", CalcBySideAndAltitude());
            }
            else if (method == 2)
            {
                Console.WriteLine("The surface of triangle is: {0:f2}", CalcByThreeSides());
            }
            else if (method == 3)
            {
                Console.WriteLine("The surface of triangle is: {0:f2}", CalcByTwoSidesAndAngle());
            }
            else
            {
                Console.WriteLine("Invalid selection!");
                method = 0;
            }
        }
    }

    private static double CalcBySideAndAltitude()
    {
        Console.Write("Length of side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Length of altitude: ");
        double altitude = double.Parse(Console.ReadLine());

        double surface = 0.5 * a * altitude;
        return surface;
    }

    private static double CalcByThreeSides()
    {
        Console.Write("Length of first side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Length of second side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Length of third side: ");
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        return surface;

    }

    private static double CalcByTwoSidesAndAngle()
    {
        Console.Write("Length of first side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Length of second side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Angle between them: ");
        double angle = double.Parse(Console.ReadLine());

        double surface = 0.5 * a * b * Math.Sin(angle);
        return surface;
    }

    static void Main()
    {
        Console.WriteLine(@"This Program will calculate the surface of 
triangle by some of methods below:");

        Console.WriteLine(@"1. Side and an altitude to it.
2. Three sides.
3. Two sides and an angle between them.");

        MenuSelectMethod();
    }
}
