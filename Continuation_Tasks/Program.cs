using System;
using System.Threading.Tasks;

namespace Continuation_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<DayOfWeek> tarefaA = new Task<DayOfWeek>(() => DateTime.Today.DayOfWeek);

            Task<string> continuacao = tarefaA.ContinueWith((antecedent) =>
                {
                return String.Format("Hoje eh {0}.", antecedent.Result);
            });

            tarefaA.Start();

            Console.WriteLine(continuacao.Result);
            Console.ReadKey();
        }
    }
}
