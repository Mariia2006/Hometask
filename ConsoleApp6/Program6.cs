using System;
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double x = Double.Parse(Console.ReadLine());
            if ( a >= 0.1 && a<= 10.0 && b >= 0.1 && b <= 10.0 && c >= 0.1 && c <= 10.0 && x >= 0.1 && x <= 1000.0)
            {
                double s = 2 * ((b * 10) * (a * 10) + (b * 10) * (c * 10) + (a * 10) * (c * 10));
                Console.WriteLine(s*x/1000);   
            }
        }
    }
}