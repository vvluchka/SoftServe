using System;

namespace SoftServe_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 variables of char type");
            string first = Console.ReadLine();
            Convert.ToChar(first);
            string second = Console.ReadLine();
            Convert.ToChar(second);
            string third = Console.ReadLine();
            Convert.ToChar(third);
            Console.WriteLine("You entered: "  + first  + ", "   + second + ", " + third);

        }
    }
}
