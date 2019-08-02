using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial7Inheritance
{
    class Animal
    {
        private string name;
        protected string sound;

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound");

        public Animal(string name, string sound)
        {
            name
        }

        public string Name
        {
            get { return name; }
            set {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";

                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set {
                if (value.Length > 10)
                {
                    sound = "No Sound";

                }
                sound = value;
            }
        }
    }
}
