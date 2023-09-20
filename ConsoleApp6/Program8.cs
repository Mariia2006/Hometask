using System;
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double p = Double.Parse(Console.ReadLine());
            if ( x <= 100 && x >= 1 && y >= 1 && y <= 100 && p >= 1 && p <= 1000) 
            {
                double result = (x * (p / (x + y))) * (y * (p / (x + y)));
                Console.WriteLine(result);
            }
        }
    }
}