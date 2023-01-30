using System;
namespace t5
{
    class test
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            calc(x);
        }
        private static void calc(int x)
        {
            if (x%2==0)
            {
                for(int i = 0; i <= x;i++)
                {
                    Console.WriteLine(i);

                }
            }
            else
            {
                int sum = 0;
                int d = 1;
                for (int i = 1;i <=x;i++)
                {

                    sum += i;
                    d *= i;


                }
                Console.WriteLine(sum);
                Console.WriteLine(d);
            }
        }
    }
}