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

    public void Calculator()
    {
        double A = dotAx + dotAy;
        double B = dotBx + dotBy;
        double C = dotCx + dotCy;
        
        Console.WriteLine($"Dot A {A}, Dot B {B}, Dot C {C}.");

    }
    
    
    
   
}

