using System;

namespace OopsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOPS CONCEPTS

            //ABSTRACTION---------
            Child2 obj = new Child2();
            obj.name("maddhu");
            obj.age(1);

            //POLYMORPHISM OVERLOADING-----------

            Calc cal = new Calc();
            cal.Heading();
            cal.Add(2, 4);
            cal.Sub(5, 1);
            cal.Tail();

            //POLYMORPHISM OVERRIDING-----------

            Parent obj1 = new Parent();
            Child3 poly = new Child3();
            obj1.Head();
            poly.name();
            obj1.profile();
            poly.PolyTail();

            //ENCAPSULATION-----------------------

            Encap encap = new Encap();
            encap.iname = "maadhu";
            encap.isalary = 1000;
            Console.WriteLine("ENCAPSULATION-------------------");
            Console.WriteLine("The name of employee is : " + encap.iname);
            Console.WriteLine("The salary of employee is : " + encap.isalary);
            Console.WriteLine("---------------------------------");

            //INHERITANCE

            Inherit par = new Inherit();
            par.ParentMethod();
            Childinher inher = new Childinher();
            inher.ChildMethod();

        }
    }
}
