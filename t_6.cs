using System;
namespace t6
{
    class test
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            calc(a);
        }
        private static void calc(int a)
        {
            Console.WriteLine(Math.Pow(a,2) + "and" + Math.Pow(a,3));
            
        }
    }
}