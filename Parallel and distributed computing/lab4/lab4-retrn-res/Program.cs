using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_retrn_res
{
    class Program
    {
        static bool MyTask()
        {
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int)v;
            int sum = 0;
            for (; x > 0; x--)
            {
                sum += x;
            }
            //
            return sum;
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is starting.");

            Task<bool> tsk1 = Task<bool>.Factory.StartNew(MyTask);
            Console.WriteLine("\nTASK1 is return logical value {0}", tsk1.Result);

            Task<int> tsk2 = Task<int>.Factory.StartNew(SumIt, 5);
            Console.WriteLine("\nResult after running SumIt = {0}", tsk2.Result);
            tsk1.Dispose();

            tsk2.Dispose();

            Console.WriteLine("\nMain method is done!");
            Console.ReadLine();
        }

    }
}
