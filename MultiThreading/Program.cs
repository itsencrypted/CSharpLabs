using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread principal iniciada");
            Thread.CurrentThread.Name = "Principal - ";

            Thread t1 = new Thread(new ThreadStart(run));
            t1.Name = "Secundaria - ";
            t1.Start();

            for (int i = 0; i<5; i++)
            {
            Console.WriteLine("Thread Atual - " + Thread.CurrentThread.Name + i);
            Thread.Sleep(3000);

            }
            Console.WriteLine("Thread Principal terminada");
            Console.Read(); 
        }

        //run
         
        public static void run()
        {
            for (int i=0; i<5; i++) {
                Console.WriteLine("Thread aatual - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }
        }
    }
} 
