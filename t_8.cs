using System;
namespace t8
{
    class test
    {
        public static void Main()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(KMM(n1, n2));


        }
        private static int BMM(int n1,int n2)
        {
            int t = 0;
            if (n2 > n1)
            {
                t = n1;
                n1 = n2;
                n2 = t;
            }
            while(true)
            {
                if (n2 == 0)
                    break;
                int temp = n1 % n2;
                n1 = n2;
                n2 = temp;
            }
            return n1;
        }
        private static int KMM(int n1,int n2)
        {
            int bmm = BMM(n1,n2);
            int k = (n1 * n2) / bmm;
            return k;
        }
    }
}