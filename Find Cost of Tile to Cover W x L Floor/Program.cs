using System;
using System.Data;

namespace Find_Cost_of_Tile_to_Cover_W_x_L_Floor;

class Program
{
    private const double COST_PER_HOUR = 86.00;
    private const int SQ_FEET_PER_HOUR = 20;

    static void Main(string[] args)
    {

        Console.WriteLine("Hello and welcome.");

        // Room shape selection
        Console.WriteLine("Please select a shape by number: \n1) rectangle \n2) square \n3) circle");
        int chosenShape = Convert.ToInt32(Console.ReadLine());

        if (chosenShape < 1 || chosenShape > 3)
        {
            Console.WriteLine("Incorrect selection. Please select a shape by number: \n1) rectangle \n2) circle \n3) square");
            return;
        }

        double area = 0.0;
        
        if (chosenShape == 1)
        {
            Console.WriteLine("Rectangle");

            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            area = width * length;
            Console.WriteLine($"{area} sq Feet of tiles will be required.");
        }

        if (chosenShape == 2)
        {
            Console.WriteLine("Square");

            Console.Write("Enter the length of a side: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            area = Math.Pow(sideLength, 2);
            Console.WriteLine($"Total area is {area}");    
        }

        if (chosenShape == 3)
        {
            Console.WriteLine("Circle");

            Console.Write("Enter the radius: ");
            double radiusInput = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radiusInput, 2);
            Console.WriteLine($"Total area is {area}");
        }

        // Cost per unit input
        Console.Write("Enter the cost per unit for tiles: ");
        double costPerUnit = Convert.ToDouble(Console.ReadLine());

        //Total Cost of Tiles calculation
        double costOfTiles = area * costPerUnit;
        Console.WriteLine($"Total Tiles cost is {costOfTiles}");

        // Total Work Hours calculation
        double totalHoursOfWork = area / SQ_FEET_PER_HOUR;
        Console.WriteLine($"Total Hours of work will be {totalHoursOfWork}");

        // Total Cost of workmen
        double costOfWorkers = totalHoursOfWork * COST_PER_HOUR;
        Console.WriteLine($"Total Workmen cost will be {costOfWorkers}");
    }
}