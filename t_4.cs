using System;
namespace t4
{
    class test1
    {
        public static void Main()
        {
            double mian = Convert.ToDouble(Console.ReadLine());
            double payan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Nahaei(mian, payan));

        }
        private static double Nahaei(double mian,double payan)
        {
            double n = (0.35 * mian)+(0.65 * payan);
            return n;
        }
    }
}