using System;
using System.Threading.Tasks;

namespace PlaygroundCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var teste = new Teste();
            Console.WriteLine(teste.nomeDaJu());

            var tarefa = new MetodoTask();
            tarefa.metodoTask();

            var t = Task.Factory.StartNew(() => FazerAlgo());

            //iniciando uma tarefa usando o factory task : instancia a classe TaskFactory
            //onde o metodoTask() eh passado para o metodo StartNew()
            TaskFactory tf = new TaskFactory();
            Task t1 = tf.StartNew(MetodoTask);

             Console.ReadKey();
        }

        static void FazerAlgo()
        {
            Console.WriteLine("executando uma tarefa => FazerAlgo() (task)");
        }

    }

}
