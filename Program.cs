using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The Number is Possitive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The Number is Zero");
            }
            string NumberType = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine("The number is " + NumberType + ".");



        }
    }
}
