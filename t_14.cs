using System;
namespace ConsoleApp1
{
    class test1
    {
        private int A;
        private int B;
        private int H;
        public test1(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
        }
        public test1()
        { }
        public int a
        {
            get { return a; }
            set { a = value; }
        }
        public int b
        {
            get { return b; }
            set { b = value; }
        }
        public int h
        {
            get { return h; }
            set { h = value; }
        }
        public double calc()
        {
            return (a + b) * h / 2;
        }
    }
    class test2
    {
        public static void Main()
        {
            test1 t = new test1();
            t.a = Convert.ToInt32(Console.ReadLine());
            t.b = Convert.ToInt32(Console.ReadLine());
            t.h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t.calc());
        }
    }

}

