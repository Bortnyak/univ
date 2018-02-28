using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task3_Priority_
{
    class Program
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("With High priority.");
            MyThread mt2 = new MyThread("with Low priority.");
            //Встановити пріоритети для потоків 
            //Вище середнього    
            mt1.Thrd.Priority = System.Threading.ThreadPriority.AboveNormal;
            //Нижче середнього    
            mt2.Thrd.Priority = System.Threading.ThreadPriority.BelowNormal;

            //Почати потоки    
            mt1.Thrd.Start();
            mt2.Thrd.Start();

            mt1.Thrd.Join();
            mt2.Thrd.Join();

            Console.WriteLine();
            Console.WriteLine("Thread " + mt1.Thrd.Name + " counted to " + mt1.Count);
            Console.WriteLine("Thread " + mt2.Thrd.Name + " counted to " + mt2.Count);
            Console.ReadLine();
        }
    }
}
