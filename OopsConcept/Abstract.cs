using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    public abstract class Abstract
    {
        public abstract void name(string a);
        public void age(int x)
        {
            Console.WriteLine("The age is : "+x);
            Console.WriteLine("---------------------");
        }
    }
    public class Child2 : Abstract
    {
        public override void name(string a)
        {
            Console.WriteLine("ABSTRACTION----------");
            Console.WriteLine("The name of the student is :" + a);
        }


    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child2 obj = new Child2();
    //        obj.name("maddhu");
    //        obj.age(1);
    //    }

    //}
}
