using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    public class Encap
    {
        private string name;
        private int salary;

        public string iname
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int isalary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
    }
    //class Extra
    //{
    //    static void Main(string[] args)
    //    {
    //        Encap encap = new Encap();
    //        encap.iname = "maadhu";
    //        encap.isalary = 1000;
    //        Console.WriteLine("ENCAPSULATION-------------------");
    //        Console.WriteLine("The name of employee is : " + encap.iname);
    //        Console.WriteLine("The salary of employee is : " + encap.isalary);
    //        Console.WriteLine("---------------------------------");
    //    }


    //}
}
