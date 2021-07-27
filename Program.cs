using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------\n" +
         "-----Welcome To Calculator-------\n" +
         "---------------------------------");
            Console.WriteLine("Input first number:");
            double fnum = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number:");
            double snum = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation : (+ , - , * , /)");
            char myopp = char.Parse(Console.ReadLine());
             
        }
    }
}
