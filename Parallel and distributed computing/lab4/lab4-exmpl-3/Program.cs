using System;
using System.Threading;
using System.Threading.Tasks;

namespace lab4_exmpl_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tsk1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Lambda_expr is started.");
                for (int count = 0; count < 10; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("In the Labda_expr counter = {0}", count);
                }
                Console.WriteLine("Lambda_expr is done.");
            });

            Console.WriteLine("Wait.....");
            tsk1.Wait();
            
            tsk1.Dispose();
            Console.WriteLine("Dispose!");

            //Продовження задачі

            var secondTask = new Task(() =>
            {
                Console.WriteLine("\nSecond Task is begin.....\n");
                MyMethod();
            });

            var thirdTask = secondTask.ContinueWith((t) => 
            {
                Console.WriteLine("\nContinuation to Second Task ---> Third Task\n");
                MyMethod2();
            });
            

            var fourthTask = thirdTask.ContinueWith((t) =>
            {
                Console.WriteLine("\nContinuation to Third Task ---> Fourth Task\n");
                MyMethod3();
            });

            secondTask.Start();
            secondTask.Dispose();
            Console.ReadLine();
        }
        static void MyMethod()
        {
            int sum = 0;
            for (int i = 0; i < 99; i++)
            {
                sum += i;
                Console.WriteLine("i = {0}", i);
            }
        }
        static void MyMethod2()
        {
            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine("i = {0}", i);
            }
        }

        static void MyMethod3()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                sum += i;
                Console.WriteLine("i = {0}, sum = {1}", i, sum);
            }
            Console.WriteLine("\n******************");
            Console.WriteLine("\n\tSUM = {0}", sum);
            Console.WriteLine("\n******************");
        }


    }
}