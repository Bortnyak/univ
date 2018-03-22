using System;
using System.Threading;
using System.Threading.Tasks;

namespace lab4_exmpl_2
{
    class Program
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask №" + Task.CurrentId + " is started.");
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In the method MyTask() №" + Task.CurrentId + " counter = " + count);
            }
            Console.WriteLine("MyTask() №" + Task.CurrentId + " is done.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is starting.");

            Task tsk1 = new Task(MyTask);
            Task tsk2 = new Task(MyTask);

            tsk1.Start();
            tsk2.Start();

            Console.WriteLine("Id of Task tsk1 = {0}", tsk1.Id);
            Console.WriteLine("Id of Task tsk2 = {0}", tsk2.Id);

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine("Main() is done");
            Console.ReadLine();
        }
    }
}
