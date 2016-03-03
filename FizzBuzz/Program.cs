using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Fizz Buzz");

            //loop for 100 numbers
            for(int i = 0; i <= 100; i++)
            {
                Console.Write(i); //print to screen the numbers

                //check if its divisible by 3
                if(i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                ////check if its divisible by 5
                if(i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine(); //print onto next line
            }
            Console.ReadLine();
        }
    }
}
