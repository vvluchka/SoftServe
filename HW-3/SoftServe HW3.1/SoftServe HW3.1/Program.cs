using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = 0,
                o = 0,
                i = 0,
                e = 0;

            foreach (int letter in str)
            {
                if (letter == 'a')
                {
                    a++;
                }
                else if (letter == 'o')
                {
                    o++;
                }
                else if (letter == 'i')
                {
                    i++;
                }
                else if (letter == 'e')
                {
                    e++;
                }
            }

            Console.WriteLine($"A in text = {a} \nO in text = {o} \nI in text = {i} \nE in text = {e}");

        }
    }
}