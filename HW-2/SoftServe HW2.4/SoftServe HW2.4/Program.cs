using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    struct Cat
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return string.Format($"My {mark} name is {name} and it is {age} years old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat;
            myCat.name = "Barsik";
            myCat.mark = "Scottish Fold Cat Breed";
            myCat.age = 3;

            Console.WriteLine(myCat);
        }
    }
}