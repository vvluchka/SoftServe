using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string max = (a > b && a > c) ? $"Max is {a}" : (b > a && a > c) ? $"Max is {b}" : $"Max is {c}";
            string min = (a < b && a < c) ? $"Min is {a}" : (b < a && a < c) ? $"Min is {b}" : $"Min is {c}";

            Console.WriteLine($"{max}\n{min}");
        }
    }
}