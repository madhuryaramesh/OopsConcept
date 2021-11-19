using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    public class Calc
    {
        public void Heading()
        {
            Console.WriteLine("POLYMORPHISM OVERLOADING-------");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine("The addition of the 2 numbers is :- "+(x+y));
            return (0);
        }

        public int Sub(int x, int y)
        {
            Console.WriteLine("The subtraction of the 2 numbers is :- " +(x - y));
            return (0);
        }

        public void Tail()
        {
            Console.WriteLine("----------------------------------");
        }
    }
    //class PolyOverload
    //{
    //    static void Main(string[] args)
    //    {
    //        Calc cal = new Calc();
    //        cal.Heading();
    //        cal.Add(2, 4);
    //        cal.Sub(5, 1);
    //        cal.Tail();

    //    }

    //}
}
