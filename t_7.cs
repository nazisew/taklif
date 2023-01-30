using System;
namespace t7
{
    class test
    {
        public static void Main()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            calc(s);
        }
        private static void calc(int s)
        {
            int year = s / 365;
            int month = (s % 365) / 30;
            int day =  (s % 365) % 30;



            Console.WriteLine("year:" + year + " month:" + month + " day:" + day);
        }
    }
}
