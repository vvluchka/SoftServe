using System;

namespace SoftServe_HW2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Enter 3 float numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(-5 < a && a < 5 ? true : false);
            Console.WriteLine(-5 < b && b < 5 ? true : false);
            Console.WriteLine(-5 < c && c < 5 ? true : false);

        }
    }
}
