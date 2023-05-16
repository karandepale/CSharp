using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpPractice
{
    internal class TypeCasting
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Implicit and Explicit Typecasting");
            int x = 100;
            float y = x;
            Console.WriteLine("value of float:- " + y);


            
            int a = 100;
            String str = Convert.ToString(a);
            Console.WriteLine("Stirng value :- " + str);
        }
    }
}
