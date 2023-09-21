using System;
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double x = Double.Parse(data[0]);
            double y = Double.Parse(data[1]);
            double p = Double.Parse(data[2]);
            if ( x <= 100 && x >= 1 && y >= 1 && y <= 100 && p >= 1 && p <= 1000) 
            {
                double result = (x * (p / (x + y))) * (y * (p / (x + y)));
                Console.WriteLine(result);
            }
        }
    }
}
