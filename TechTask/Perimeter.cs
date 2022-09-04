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
        //Calculates the sides of the triangles and store the value in the variables
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

        //Compares the lenght of the sides to see if they are equal
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

        //Checks if the triangle is right using Pythagoras theorem a2 + b2 = c2
        if (lenghtAB >= lenghtBC || lenghtAB >= lenghtAC)
        {
            if (lenghtBC + lenghtAC == lenghtAB)
            {
                Console.WriteLine("Triangle IS 'Right'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Right'");
            }
        }
        else if (lenghtBC >= lenghtAB || lenghtBC >= lenghtAC) {
            if (lenghtAB + lenghtAC == lenghtBC)
            {
                Console.WriteLine("Triangle IS 'Right'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Right'");
            }
        }
        else if (lenghtAC >= lenghtAB || lenghtAC >= lenghtBC)
        {
            if (lenghtAB + lenghtBC == lenghtAC)
            {
                Console.WriteLine("Triangle IS 'Right Angled'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Right Angled'");
            }
        }


        //Calculates the perimeter of the triangle
        double perimeter = lenghtAB + lenghtAC + lenghtBC;
        Console.WriteLine($"\nPerimeter: '{perimeter}'");

        //For loop to print out even numbers from 0 up to the perimeter of the triangle
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

