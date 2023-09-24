using System;
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);
            double x = double.Parse(data[3]);
            if (a >= 0.1 && a <= 10.0 && b >= 0.1 && b <= 10.0 && c >= 0.1 && c <= 10.0 && x >= 0.1 && x <= 1000.0)
            {
                double gen = 2 * (b * a * 100 + b * c * 100 + a * c * 100);
                double s = gen * (x / 1000);
                double d = Math.Ceiling(s);
                Console.WriteLine(d);
            }
        }
    }
}
