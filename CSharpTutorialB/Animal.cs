using System;

namespace CSharpTutorialB
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            //I want to be able to refer to my objects version & name, but I also want to be able to refer
            //to THIS VERSION and name and attribute up here 
            this.name = name;
            this.sound = "No sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            //I want to be able to refer to my objects version & name & sound, but I also want to be able to refer to THIS VERSION and name and sound and attribute up here. 
            this.name = name;
            this.sound = sound;

            //We're gonna increment the number of animals inside our constructor
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        static int numOfAnimals = 0;
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}

/* Once this is done, we go back to our Main() go back to Program.cs and create an Animal Object */
