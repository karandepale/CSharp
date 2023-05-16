using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpPractice
{
    internal class Operations
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter first value : ");
            int val1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Second value : ");
            int val2 = Convert.ToInt16(Console.ReadLine());

            int Addition = val1 + val2;
            Console.WriteLine("Addition of " + val1 + " And " + val2 + " is :  " + Addition);

            int Sub = val1 - val2;
            Console.WriteLine("Subtraction of " + val1 + " And " + val2 + " is :  " + Sub);

            int multiplication = val1 * val2;
            Console.WriteLine("Multiplication of " + val1 + " And " + val2 + " is :  " + multiplication);

            int division = val1 / val2;
            Console.WriteLine("Division of " + val1 + " And " + val2 + " is :  " + Addition);


        }
    }
}
