using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Student 
    {
        //The subclass or the child class or the derived class
        #region Data or Fields
        //copy paste from Person
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        //False : Female;
        public bool Gender;
        #endregion

        #region Extended Fields of Students
        public float GPA;
        public byte CompletedCourse;
        public DateTime JoinDate;
        #endregion

        #region Logic or Methods or Functions or Behaviors
        public void Display()
        {
            Console.WriteLine("Student : " + FirstName + " " + LastName);
            Console.WriteLine("GPA: " + GPA);
            Console.WriteLine("Date of Birth: " + DateOfBirth.ToString());
            Console.WriteLine("Completed Courses: " + CompletedCourse.ToString());
        }
        #endregion

    }
}
