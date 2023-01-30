using System;
namespace program
{
    class test1
    {
        public static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calc(x));


        }
        private static double calc(double x)
        {
            return Math.Abs(Math.Pow(x, 2) + Math.Pow(2, x) + Math.Sqrt(x));
        }
    }
}