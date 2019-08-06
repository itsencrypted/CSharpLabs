using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class DestructorClass
    {
        public List<string> List;
        public DestructorClass()
        {
            Console.WriteLine("Class is created");
            List = new List<string>(2000);
            Console.WriteLine("list capacity: " + List.Capacity);
        }

        ~DestructorClass()
        {
            List = null;
            Console.WriteLine("Destructor is called from Destructor Class");
        }
    }
    //class DestructorClass2 : DestructorClass
    //{
    //    public List<string> List;
    //    public DestructorClass2()
    //    {
    //        Console.WriteLine("Class2 is created");
    //        List = new List<string>(2000);
    //        Console.WriteLine("List capacity: " + List.Capacity);
    //    }

    //    ~DestructorClass2()
    //    {
    //        List = null;

    //        Console.WriteLine("Destructor2 is called from DestructorClass2");
    //    }
    //}
}
