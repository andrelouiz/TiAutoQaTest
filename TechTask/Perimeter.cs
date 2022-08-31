using System.Collections;

namespace TechTask;

public class Perimeter
{
    public double dotAx { get; set; }
    public double dotAy { get; set; }
    public double dotBx { get; set; }
    public double dotBy { get; set; }
    public double dotCx { get; set; }
    public double dotCy { get; set; }

    public Perimeter(double dotAx, double dotAy , double dotBx, double dotBy, double dotCx, double dotCy)
    {
        this.dotAx = dotAx;
        this.dotAy = dotAy;
        this.dotBx = dotBx;
        this.dotBy = dotBy;
        this.dotCx = dotCx;
        this.dotCy = dotCy;
        
        double A = dotAx + dotAy;
        double B = dotBx + dotBy;
        double C = dotCx + dotCy;
        
        Console.WriteLine($"Dot A {0}, Dot B {1}, Dot C {2}.", A, B, C);
    }

    public void Calculator()
    {
        double A = dotAx + dotAy;
        double B = dotBx + dotBy;
        double C = dotCx + dotCy;
        
        Console.WriteLine($"Dot A {0}, Dot B {1}, Dot C {2}.", A, B, C);

    }
    
    
    
   
}

