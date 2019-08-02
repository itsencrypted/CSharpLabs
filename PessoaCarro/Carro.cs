using System;
using System.Collections.Generic;
using System.Text;

namespace PessoaCarro
{
   public class Carro
    {
        public string Brand;
        //public bool F1;
        public Pessoa Driver1;
        public Pessoa Passenger;
        public int Capacity;

        // construtor 
        public Carro() {}

        //if usado quando voce tem mais de 1 parametro para analisar.
        //if, else if, else if, else if, else if, else
        //switch-case: quando voce tem um parametro porem varios cenarios de resposta.


        public void Drive()
    {
        if (Driver == null)
        {
            Console.WriteLine("There's no driver in the car.");
        }
        else if (Driver != null && Driver.IsOlderthan18() == true)
        {
            Console.WriteLine($"Awesome {Driver.Name}! If you are {Driver.Age}, you can drive a car!! What model would you like to drive?");
            Brand = Console.ReadLine();
            Console.WriteLine($"{Driver.Name} is driving a {Brand}");
        }
        else if (Driver != null && Driver.IsOlderthan18() == false)
        {
            Console.WriteLine($"{Driver.Name} , you cannot drive a car yet. Wait until you're 18 and get a Driver´s License.");
        }
        else
        {
            Console.WriteLine("This is probably a self-driving car. Watch out and get out of the way");
        }

    }
        

        //public bool PilotTheF1(bool F1)
        //{
        //    if(F1 == true)
        //    {
        //        return true;
        //    } else
        //    {
        //        return false;
        //    }
        //}
    }
}
