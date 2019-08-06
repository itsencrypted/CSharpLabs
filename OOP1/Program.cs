 using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic resolves at runtime 

            //Person person = new Person();

            ////var resolves at compile time 
            ////var person = new Person();

            //person.FirstName = "Alice";
            //person.Walk();
            ////person = null;
            ////GC.Collect();

            //var destructor = new DestructorClass();
            //destructor = null;
            //GC.Collect();

            //*********************************************************//

            var std = new Student();
            std.FirstName = "Alice";
            std.LastName = "Romanson";
            std.CompletedCourse = 123;
            std.Display();

            Console.ReadKey();      


        }
    }
}
