using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Teacher
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

        #region Extended Fields of Teacher
        public string SubjectProficiency;
        public string OfficeHours;
        public string Department;
        #endregion

        #region Logic or Methods or Functions or Behaviors
            
        public void Display()
        {
            Console.WriteLine("Teacher : " + FirstName + " " + LastName);
            Console.WriteLine("Subject Proficiency: " + SubjectProficiency);
            Console.WriteLine("Office Hours: " + OfficeHours.ToString());
            Console.WriteLine("Department: " + Department.ToString());
        }
        #endregion
    }
}
