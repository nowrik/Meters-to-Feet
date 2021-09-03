using System;

namespace num_6_pg_190
{
    class Program
    {
        static void Main()
        {

            double Mval;

            Console.Write("Enter Metric Value To Be Converted: ");
            Mval = double.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Entered Value is equal to {0} Feet and {1:N1} Inches.", MtoF(Mval), remMtoI(Mval));
            Console.WriteLine("\nPress Enter Twice to Quit.");
            Console.Read();
            
        }
        public static double MtoF (double Value)
        {
            return Math.Truncate(Value * 3.281);
        }
        public static double remMtoI (double Value)
        {
            return ((Value*39.3700787) % 12);
        }
    }
}
