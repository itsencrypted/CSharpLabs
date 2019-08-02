using System;
using System.Collections.Generic;
using System.Text;


namespace PessoaCarro
{
    public class Pessoa
    {
        public string Name;
        public int Age;
        public Carro Car;


        public Pessoa() { }
        
        
        //metodo talk
        public void Talk(string frase)
        {
            Console.WriteLine($"{Name} said {frase}.");
        }

        public bool IsOlderthan18()
        {
            if (Age >= 18)
            {
                var yes = true;
                return yes;
            }
            else
            {
                var no = false;
                return no;
            }
        }

        //public bool IsPilot(bool pilot)
        //{
        //    if(pilot == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}





