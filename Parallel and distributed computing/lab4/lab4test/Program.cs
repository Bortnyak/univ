using System;
using System.Threading.Tasks;

namespace lab4test
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(MyTask1.Run);
            Task task2 = new Task(MyTask2.Begin);
            Task task3 = new Task(MyTask3.Go);
            Task task4 = new Task(MyTask4.Now);
            Task task5 = new Task(MyTask5.Start);


            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();

            Console.ReadLine();
        }
    }
}
