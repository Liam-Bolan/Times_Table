using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Times_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I will be testing your times tables.");

            Console.WriteLine("What is your name?");

            string username = Console.ReadLine();

            Console.WriteLine($"Hello " + (username));
            int Number;
            try
            {
                Console.WriteLine($"What times table do you want to be tested on (2-12) " + (username));
                Number = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Type in a number!");
            }
            int timestable = int.Parse(Console.ReadLine());
            do

            {
                Console.WriteLine("Invalid Number!");

            } while (timestable < 1 || timestable > 13);

            if (Number > 1 | Number < 13)
            {
                Console.WriteLine("Okay!");
                Console.ReadLine();
            }
            else Console.WriteLine("Invalid Number!");

        }

    }
}







