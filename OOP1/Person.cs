using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    //The superclass or the parent class or the base class
    class Person
    {

        //constructor
        public Person()
        {
            Console.WriteLine("Person Created.");
        }

        #region Data or Fields without Encapsulation

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        //False : Female;
        public bool Gender;

        #endregion

        #region Logic or Methods or Functions or Behaviors

        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Eat()
        {
            Console.WriteLine(FirstName + " is eating.");
        }

        #endregion
        #region Destructor
        ~Person()
        {
            //destructor
            Console.WriteLine("Constructor is called");
        }
        #endregion
    }

}
