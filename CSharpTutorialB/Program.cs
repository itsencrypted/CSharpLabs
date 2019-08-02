using System;

namespace CSharpTutorialB
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal fox = new Animal()
            {
                name = "Red Fox",
                sound = "Raaaawwwn"
            };

            fox.MakeSound();

            //GetNumAnimals is a method so you put () after it.
           Console.WriteLine("# of Animals : {0}", Animal.GetNumAnimals());
           Console.ReadLine();
        }
    }
}
