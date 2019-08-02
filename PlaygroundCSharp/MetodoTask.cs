using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundCSharp
{
    public class MetodoTask
    {
        public void metodoTask()
        {
            Console.WriteLine("executando uma tarefa (task)");
            Console.WriteLine("Task id: {0}", Task.CurrentId);
        }
    }
}
