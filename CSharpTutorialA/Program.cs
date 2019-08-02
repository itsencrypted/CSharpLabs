using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorialA
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            //we're going to be able to add values to it
            rect1.lenght = 200;
            rect1.width = 50;

            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            Console.ReadLine();

            //we're gonna create another Rectangle here, but this time we're using our constructor. And to
            //do this we write new Rectangle and we can pass the lenght and the width
            Rectangle rect2 = new Rectangle(100, 40);

            //If you're assigning one Rectangle to another, you're going to be setting the values and not
            //creating a reference

            rect2 = rect1;
            rect1.lenght = 33;

            Console.WriteLine("Area of rect1: {0} :", rect1.Area());
            Console.WriteLine("Lenght of Rect2 {0} :", rect2.lenght);

        }

        struct  Rectangle
        {
            public double lenght;
            public double width;
            //constructor method has exactly the same name as a struct. A constructor is just a way to
            //initialize a struct that has just been created.
            public Rectangle(double l = 1, double w=1)
            {
                lenght = l;
                width = w;
            }

            //after that you can create methods
            public double Area()
            {
                return lenght * width;
            }

            //after all this is done, go back to MAIN and create a Rectangle struct and call this 
            //Rectangle rect1
        }
    }
}
