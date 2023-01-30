using System;
namespace toolKhat
{
    class test1
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        public double A
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double B
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double C
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double D
        {
           get { return y2; }
            set { y2 = value; }
        }

        public test1(int a,int b,int c,int d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
        public test1 (){}

        public double Tool()
        {
            double tool = Math.Sqrt(Math.Pow(x2-x1 ,2) + Math.Pow(y2-y1 ,2));
            return tool;
        }
    }
    class test2
    {
        public static void Main()
        {
            test1 t = new test1();
            t.A=Convert.ToInt32(Console.ReadLine());
            t.B=Convert.ToInt32(Console.ReadLine());
            t.C = Convert.ToInt32(Console.ReadLine());
            t.D = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(t.Tool());


        }
    }
}
