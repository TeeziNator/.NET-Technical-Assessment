using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your input!");
            string numbersInput = Console.ReadLine().ToString();

            Calculator calculate = new Calculator();
            Console.WriteLine("Your results: {0}", calculate.Add(numbersInput));

            Console.ReadKey();
        }
    }
}
