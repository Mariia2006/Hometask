using System;
namespace Program 
{ 
  class Program
  {
    static void Main( string[] args)
    {
      double a = 0;
      double b = 0;  
      double c = 0;  
      a = Convert.ToDouble(Console.ReadLine());
      b = Convert.ToDouble(Console.ReadLine());
      c = Convert.ToDouble(Console.ReadLine());
      if (a > 0 && a < 1000 && b > 0 && b < 1000 
  && c > 0 && c < 1000 && a+b > c && b+c > a && a+c > b)
      {
        double m_a = 0.5 * 0.1 * (Math.Sqrt(2 * (Math.Pow(b, 2))) + (2 * (Math.Pow(c, 2))) - Math.Pow(c, 2));
        double m_b = 0.5 * 0.1 * (Math.Sqrt(2 * (Math.Pow(a, 2))) + (2 * (Math.Pow(c, 2))) - Math.Pow(b, 2));
        double m_c = 0.5 * 0.1 * (Math.Sqrt(2 * (Math.Pow(b, 2))) + (2 * (Math.Pow(a, 2))) - Math.Pow(c, 2));
        Console.WriteLine(m_a);
        Console.WriteLine(m_b);
        Console.WriteLine(m_c);
      }
    }
  }
}
