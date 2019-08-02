using System;
using System.Threading.Tasks;

namespace TasksOrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string>[] tarefas = new Task<string>[6];
            tarefas[0] = new Task<string>(() =>
            {
                return "Male-Vinicius";
            });

            tarefas[1] = new Task<string>(() =>
            {
                return "Female-Juliana";
            });

            tarefas[2] = new Task<string>(() =>
            {
                return "Female-Maisa";
            });

            tarefas[3] = new Task<string>(() =>
            {
                return "Male-Felipe";
            });

            tarefas[4] = new Task<string>(() =>
            {
                return "Male-Nickolas";
            });

            tarefas[5] = new Task<string>(() =>
            {
                return "Male-Guilherme";
            });


            var continuation = Task.Factory.ContinueWhenAll(
                tarefas, (antecendents) =>
                {
                    string[] names = new string[6];

                    names[0] = tarefas[0].Result;
                    names[1] = tarefas[1].Result;
                    names[2] = tarefas[2].Result;
                    names[3] = tarefas[3].Result;
                    names[4] = tarefas[4].Result;
                    names[5] = tarefas[5].Result;

                    Array.Sort(names);

                    for (int row = 0; row < names.Length; row++)
                        Console.WriteLine(names[row]);

                });

            tarefas[0].Start();
            tarefas[1].Start();
            tarefas[2].Start();
            tarefas[3].Start();
            tarefas[4].Start();
            tarefas[5].Start();
            continuation.Wait();
            Console.ReadKey();
        }
    }
}
