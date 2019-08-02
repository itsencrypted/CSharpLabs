using System;

namespace CSharpTutorial6
{
    class Program
    {
        static void Main(string[] args) 
        {
            Animal cat = new Animal();
            cat.SetName("Michi Gato");
            cat.Sound = "Miau";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            //work with auto-generated getter & setter

            cat.Owner = "Juliana";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

            Animal fox = new Animal("Raposinha", "Wooof");

            Console.WriteLine("# of Animals: {0}", Animal.NumOfAnimals);

            Console.ReadLine();
        }
    }
}
