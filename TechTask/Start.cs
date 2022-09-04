namespace TechTask;
public class Start
{
    public static void Menu()
    {
        Console.WriteLine("Triangle perimeter calculator");

        Triangle triangle = new Triangle();
        
        Console.WriteLine("Enter the coordinate of y of dot A:"); 
        triangle.dotAx = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the coordinate of y of dot A:"); 
        triangle.dotAy = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of x of dot B:");
        triangle.dotBx = Double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the coordinate of y of dot B:");
        triangle.dotBy = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of x of dot C:");
        triangle.dotCx = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinate of y of dot C:");
        triangle.dotCy = Double.Parse(Console.ReadLine());

        triangle.LenghtCalc();

        Console.ReadKey();

    }
}