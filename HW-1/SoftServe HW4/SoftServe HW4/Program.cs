using System;

namespace SoftServe_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int y = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(x >= 0 && y >= 0);
        }
    }
}
