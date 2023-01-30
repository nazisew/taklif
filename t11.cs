using System;
namespace zoozanaghe
{


    class test2
    {
        private int A;
        private int B;
        private int H;

        public test2(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
        }
        public test2() { }
        public int a
        {
            get { return A; }
            set { A = value; }
        }
        public int b
        {
            get { return B; }
            set { B = value; }
        }
        public int h
        {
            get { return H; }
            set { H = value; }
        }
        public int S()
        {
            return (A + B) / 2;
        }

    }
    class test1
    {
        public static void Main()
        {
            test2 t = new test2();
            t.a = Convert.ToInt32(Console.ReadLine());
            t.b = Convert.ToInt32(Console.ReadLine());
            t.h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t.S());



        }
    }
}

