using System;

namespace SoftServe_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of square side ");
            int length = Convert.ToInt32(Console.ReadLine());
            int area = length * length;
            int perimeter = length * 4;
            Console.WriteLine("Area = " + area + ", " + "perimeter = " + perimeter);
            

        }
    }
}
