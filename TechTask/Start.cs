using static TechTask.Perimeter;

namespace TechTask;
public class Start
{
    public static void Menu()
    {
        Console.WriteLine("Triangle perimeter calculator");

        Perimeter perimeter = new Perimeter();
        
        Console.WriteLine("Enter the coordinate of y of dot A:"); 
        perimeter.dotAx = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the coordinate of y of dot A:"); 
        perimeter.dotAy = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of x of dot B:");
        perimeter.dotBx = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the coordinate of y of dot B:");
        perimeter.dotBy = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of x of dot C:");
        perimeter.dotCx = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of y of dot C:");
        perimeter.dotCy = Double.Parse(Console.ReadLine());
        
        perimeter.LenghtCalc();

        Console.ReadKey();

    }
}