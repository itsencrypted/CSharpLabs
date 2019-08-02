using System;
using System.Threading.Tasks;

namespace Continuation_Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tarefas = new Task<int>[3];
            tarefas[0] = new Task<int>(() =>
           {
               return 34;
           });

            tarefas[1] = new Task<int>(() =>
            {
                return 8;
            });

           tarefas[2] = new Task<int>(() =>
            {
                return 2;
            });

            var teste = string.;

            var continuation = Task.Factory.ContinueWhenAll(
                tarefas, (antecendents) =>
                {
                    int resposta = tarefas[0].Result + tarefas[1].Result + tarefas[2].Result;
                    Console.WriteLine("A resposta eh {0}", resposta);
                });

            tarefas[0].Start();
            tarefas[1].Start();
            tarefas[2].Start();
            continuation.Wait();
            Console.ReadKey();
        }
    }
}
