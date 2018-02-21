using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;


namespace Lab1
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), "Hello from Main()!");
            Console.WriteLine("Doing more work in Main()!");
            while (!isDone)
            {
                Console.WriteLine("doing something in Main()!");
                Thread.Sleep(1000);
            } 
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }
        static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your addition is complete");
            AsyncResult ar = (AsyncResult)itfAR;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine((string)itfAR.AsyncState + "\n10 + 10 is {0}.", b.EndInvoke(itfAR));
            isDone = true;
        }
    }
}
