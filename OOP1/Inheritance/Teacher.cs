using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1.Inheritance
{
    class Teacher : Person
    {
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

    

