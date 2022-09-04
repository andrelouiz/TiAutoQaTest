using System.Collections;
using System;
using static TechTask.Start;

namespace TechTask;

public class Triangle
{
    public double dotAx { get; set; }
    public double dotAy { get; set; }
    public double dotBx { get; set; }
    public double dotBy { get; set; }
    public double dotCx { get; set; }
    public double dotCy { get; set; }
    
    public void LenghtCalc()
    {
        double xAB = dotAx - dotBx;
        double yAB = dotAy - dotBy;
        double lenghtAB = Math.Sqrt((xAB * xAB) + (yAB * yAB));
       
        double xBC = dotBx - dotCx;
        double yBC = dotBy - dotCy;
        double lenghtBC = Math.Sqrt((xBC * xBC) + (yBC * yBC));
       
        double xAC = dotAx - dotCx;
        double yAC = dotAy - dotCy;
        double lenghtAC = Math.Sqrt((xAC * xAC) + (yAC * yAC));

        Console.WriteLine($"\n Lenght AB = {lenghtAB}\n Lenght BC = {lenghtBC}\n Lenght AC = {lenghtAC}\n ");

        if (lenghtAB == lenghtBC & lenghtBC == lenghtAC)
        {
            Console.WriteLine("Triangle IS 'Equilateral'");
        }
        else if (lenghtAB == lenghtBC || lenghtBC == lenghtAC || lenghtAB == lenghtAC)
        {
            Console.WriteLine("\nTriangle IS NOT 'Equilateral'. \nTriangle IS 'Isoceles'");
        }
        else
        {
            Console.WriteLine("Triangle IS 'Scalene'");
        }

        if (lenghtAB == lenghtBC + lenghtAC || lenghtBC == lenghtAC + lenghtAB || lenghtAC == lenghtAB + lenghtBC)
        {
            Console.WriteLine("Triangle IS 'Right'");
        }
        else
        {
            Console.WriteLine("Triangle IS NOT 'Right'");
        }

        double perimeter = lenghtAB + lenghtAC + lenghtBC;

        Console.WriteLine($"\nPerimeter: '{perimeter}'");

        Console.WriteLine("\nParity of the numbers in rage from 0 to triangle perimeter:");
        for (int i = 0; i < perimeter; i++)
        {
            if (i % 2  == 0)
            {   
                Console.WriteLine(i);
            }
        }

    }

   

}

