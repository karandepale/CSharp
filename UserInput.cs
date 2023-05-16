using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpPractice
{
    internal class UserInput
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your name : ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello mr. " + name);
        }
    }
}
