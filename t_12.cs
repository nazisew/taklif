using System;
namespace haghotadris
{
    class test
    {
        public static void Main()
        {
            test1 t = new test1();
            Console.WriteLine("Name:");
            t.Name = Console.ReadLine();
            Console.WriteLine("Family Name:");
            t.FamilyName = Console.ReadLine();
            Console.WriteLine("id:");
            t.Num = Console.ReadLine();
            Console.WriteLine("Price:");
            t.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time:");
            t.Time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t.S());
        }
    }

    class test1
    {
        private string num;
        private string name;
        private string familyName;
        private int time;
        private int price;

        public test1(string Num,string Name,string FamilyName,int Time,int Price)
        {
            num = Num;
            name = Name;
            familyName = FamilyName;
            time = Time;
            price = Price;
        }
        public test1()
        { }

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        public int Time
        {
            get { return time; }
            set
            {
                if (value > 0)
                { time = value; }
                else
                { time = 0; }
            }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int S()
        {
            return Time * Price;
        }
    }
}




























