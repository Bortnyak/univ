using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2_Task4_Indvd_
{
    class Program
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("mt1", "Highest");
            MyThread mt2 = new MyThread("mt2", "Above Normal");
            MyThread mt3 = new MyThread("mt3", "Lowest");


            Stopwatch threadTimeAll = new Stopwatch();
            //Запускаю таймер
            threadTimeAll.Start();
            //////////////////////////////////////
            //Запускаю потоки
            mt1.Thrd.Start();
            mt2.Thrd.Start();
            mt3.Thrd.Start();

            //Зупиняю потоки
            mt1.Thrd.Join();
            mt2.Thrd.Join();
            mt3.Thrd.Join();

            //Зупиняю таймер
            threadTimeAll.Stop();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("TIME: " + threadTimeAll.ElapsedMilliseconds.ToString() + " ms");
            Console.ReadLine();
        }
    }
}
