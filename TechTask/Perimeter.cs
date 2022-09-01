using System.Collections;
using System;
using static TechTask.Start;

namespace TechTask;

public class Perimeter
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
        double lenghtA = Math.Sqrt((xAB * xAB) + (yAB * yAB));
       
        double xBC = dotBx - dotCx;
        double yBC = dotBy - dotBy;
        double lenghtB = Math.Sqrt((xBC * xBC) + (yBC * yBC));
       
        double xAC = dotAx - dotCx;
        double yAC = dotAy - dotCy;
        double lenghtC = Math.Sqrt((xAC * xAC) + (yAC * yAC));
       
        Console.WriteLine($"Lenght A = {lenghtA}\n Lenght B = {lenghtB}\n Lenght C = {lenghtC}\n ");
    }
    
}

public class Calculator : Perimeter
{
    public void SumCalculator()
    {
        double A = dotAx + dotAy;
        double B = dotBx + dotBy;
        double C = dotCx + dotCy;
        
        Console.WriteLine($"Dot A {A}, Dot B {B}, Dot C {C}.");
    }


    
}

