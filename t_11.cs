using System;
namespace hour
{
    class test1
    {
        public static void Main()
        {
            
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            test t = new test(hour,minute);
            t.time();



        }
    }
    class test
    {
        private int hour;
        private int minute;
        public int H
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public test(int H, int M)
        {
            hour = H;
            minute = M;
        }
        public test() { }

        public void time()
        {
            if (hour <= 12)
            {
                Console.WriteLine(hour +":"+ minute + "Am");
            }
            else
            {
                hour -= 12;
                Console.WriteLine(hour +":" + minute + "pm");
            }
        }

    }
    
}