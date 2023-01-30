using System;
namespace program
{
    class test1
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()); 
            int c = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(H(a, b, c));

        }
        private static int H(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}