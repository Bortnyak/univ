using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;


namespace Task3
{
    public delegate double BinaryOp(double x, double y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(CompareValue);
            IAsyncResult iftAR = b.BeginInvoke(11.2, 13.4, new AsyncCallback(AvarageComplete), "");
            while (!isDone)
            {

                Thread.Sleep(1000);
                Console.WriteLine("Done");
            }
            Console.ReadLine();
        }


        static double CompareValue(double x, double y)
        {
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            //Thread.Sleep(5000);
            double bigger = 0;
            if (x > y)
            {
                bigger = x;
            }
            else if (x < y)
            {
                bigger = y;
            }
            else
            {
                Console.WriteLine("========================================");
            }
            return bigger;

        }

        static void AvarageComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("CompareComplete() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            AsyncResult ar = (AsyncResult)itfAR;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine((string)itfAR.AsyncState + "\n11.2 vs 13.4 -> {0}.", b.EndInvoke(itfAR));
            isDone = true;
        }
    }
}
