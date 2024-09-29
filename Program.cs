using System;
namespace Multadd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MultiAdd(1.0 , 2.0, 3.0) = " + MultAdd(1.0, 2.0, 3.0));
            
            double pi = Math.PI;
            double snpiover4 = Math.Sin(pi/4);
            double cspiover2 = Math.Cos(pi/2);
            Console.WriteLine("sin(π/4) + cos(π/2) = " + Math.Round(MultAdd(1.0, snpiover4, cspiover2),4));

            double log10 = Math.Log(10);
            double log20 = Math.Log(20);
            Console.WriteLine("log 10 + log 20 = " + Math.Round(MultAdd(1.0,log10, log20),4));

            Console.WriteLine(Math.Round(Yikes(2.0),4));
        }
        static double MultAdd(double a, double b, double c)
        {
            return a * b + c;
        }

        static double Yikes(double x)
        {
            return (x * Math.Exp(-x)) + Math.Sqrt(1 - Math.Exp(-x));
        }

    }
}
