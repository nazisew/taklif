using System;
namespace program
{
    class test
    {
        public static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());

            if (a1 + a2 > a3 && a1 + a3 > a2 & a2 + a3 > a1)
            {
                Console.WriteLine(M(a1, a2, a3));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        private static int M(int x, int y, int z)
        {
            int m;
            m = x + y + z;
            return m;   
            
        }
    }
}