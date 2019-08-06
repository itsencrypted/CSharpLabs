using System;

namespace AccountClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Account warren = new Account();
            warren.balance = 1000;

            Account soros = new Account();
            warren.Transfer(10.0, warren, soros);

            Console.WriteLine("Hello World!");
        }
    }
}
