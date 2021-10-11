using System;

namespace SoftServe_HW6
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();                  
            Console.WriteLine("How old are you " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is - " + name + ", " + "and your age is - " + age); 
            

    }
    }
}
