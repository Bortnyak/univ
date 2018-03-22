using System;
using System.Threading.Tasks;
using System.Threading;

namespace lab4_exmpl_invoke
{
    class Program
    {
        static void MyMeth1()
        {
            Console.WriteLine("MyMeth1 is started.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In the method MyMeth1() counter = {0}", count);
            }
        }
        static void MyMeth2()
        {
            Console.WriteLine("MyMeth2() is started.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In the method MyMeth2() counter = {0}", count);
            }
            Console.WriteLine("MyMeth2() is done.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is starting.");
            Parallel.Invoke(MyMeth1, MyMeth2);
            Console.WriteLine("Main is done.");
            Console.ReadLine();
        }
    }
}
