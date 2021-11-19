using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    public class Parent
    {
        public void Head()
        {
            Console.WriteLine("POLYMORPHISM OVERRIDING-----------------");
        }
        public virtual void profile()
        {
            Console.WriteLine("Engineer");
        }

        public virtual void name()
        {
            Console.WriteLine("Maadhu");
        }
    }

    public class Child3 : Parent
    {
        public override void profile()
        {
            Console.WriteLine("Software");
        }
        public override void name()
        {
            Console.WriteLine("Ramesh");
        }
        public void PolyTail()
        {
            Console.WriteLine("--------------------------------------");
        }
    }
    //class PolyOverrid
    //{
    //    //Parent obj1 = new Parent();
    //    //Child3 obj = new Child3();
    //    //obj.name();
    //    static void Main(string[] args)
    //    {
    //        Parent obj1 = new Parent();
    //        Child3 obj = new Child3();
    //        obj1.Head();
    //        obj.name();
    //        obj1.profile();
    //        obj.Tail();
    //    }

    //}
}
