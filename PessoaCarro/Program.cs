using System;

namespace PessoaCarro
{
    class Program
    {    
        static void Main(string[] args)
        {

            //inicializou a variavel 
            int age = 0;
            string name = string.Empty;

            Pessoa driver = new Pessoa
            {
                Name = name,
                Age = age
            }; 

            Pessoa passenger = new Pessoa
            {
                Name = name,
                Age = age
            };

            Console.WriteLine("What's your name?");
            passenger.Name = Console.ReadLine();
            
            Carro car = new Carro();

            Console.WriteLine($"What car brand would you like to pick, today {passenger.Name}?");
            car.Brand = Console.ReadLine();

            //constructor do carro mora aqui na program

            //colocar pessoa dentro do carro
            Console.WriteLine($"{passenger.Name} is in the {car.Brand}");
            Console.WriteLine("How old are you ?");

            //depois de ela estar dentro, ela pode
            //verifico se pode drive

            age = Convert.ToInt32(Console.ReadLine( ));

           car.Drive();
            //executa metodo drive()
            //termina com o talk

            Console.WriteLine($"To finalize, please say a motivational quote");
            string quote = Console.ReadLine();

            car.Driver = driver;

            car.Drive();

            driver.Talk(quote);


            //var x = driver.IsPilot(true);
            //if (x == true)
            //{
            //    Console.WriteLine($"{driver.name} is a pilot");
            //}

           
            //car.PilotTheF1(true); */

    
        }
    }
}
