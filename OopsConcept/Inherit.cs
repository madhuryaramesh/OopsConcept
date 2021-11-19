using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    public class Inherit
    {
        public void ParentMethod()
        {
            Console.WriteLine("INHERITANCE-------------------");
            Console.WriteLine("Hello Madhurya");
        }
    }
    class Childinher : Inherit
    {
        public void ChildMethod()
        {
            Console.WriteLine(" Welcome to BridgeLabz");
            Console.WriteLine(" ---------------------------- ");

            //static void Main(string[] args)
            //{
            //    Inherit par = new Inherit();
            //    par.ParentMethod();
            //    Childinher inher = new Childinher();
            //    inher.ChildMethod();

            //}

        }
    }



}
