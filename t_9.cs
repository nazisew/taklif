using System;
namespace t9
{
    class test
    {
        public static void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int darsad = Convert.ToInt32(Console.ReadLine());
            int target = Convert.ToInt32(Console.ReadLine());  
            calc(m,darsad,target);
            
        }
        private static void calc(int m,int darsad,int target)
        {
            int y = 1;
            if (m < target)
            {
                m += m * (darsad / 100);

                Console.WriteLine("mablagh bad az" + y + "sal mishe :" + m);
                y++;
            }
            Console.WriteLine("bad az " + y + "sal be target miresi");
        }
        
    }
}