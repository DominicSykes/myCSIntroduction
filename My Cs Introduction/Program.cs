
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mr. ";
            string lastName = "Sykes";
            string name = firstName + lastName;
            int myAge = 25;
            string Occupation = "Computer Systems Technician";
            string grad = "Graduated from Gow school in 2015 and Vector Tech in 2019";
            Console.WriteLine("1. "+name);
            Console.WriteLine("2. " +myAge + " years old");
            Console.WriteLine("3. " + grad);
            Console.WriteLine("4. I work as a " + Occupation);
            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
