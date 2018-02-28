using System;
using System.Threading;
using System.Diagnostics;

namespace Lab2_Task4_Indvd_
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;
        public string ThrdPrtName;
        public double res;

        static bool stop = false;
        static string currentName;

        public string ThrdPrt
        {
            get { return ThrdPrtName; }
            set { ThrdPrtName = value; }
        }

        //Сконструювати, але не починати виконання нового потоку   
        public MyThread(string name, string priority)
        {
            Count = 0;
            Thrd = new Thread(Run);

            ThrdPrtName = priority;
            Thrd.Name = name;
            currentName = name;

            if (priority == "Highest")
            {
                Thrd.Priority = System.Threading.ThreadPriority.Highest;
            }
            else if (priority == "Above Normal")
            {
                Thrd.Priority = System.Threading.ThreadPriority.AboveNormal;
            }
            else if (priority == "Normal")
            {
                Thrd.Priority = System.Threading.ThreadPriority.Normal;
            }
            else if (priority == "Below Normal")
            {
                Thrd.Priority = System.Threading.ThreadPriority.BelowNormal;
            }
            else if (priority == "Lowest")
            {
                Thrd.Priority = System.Threading.ThreadPriority.Lowest;
            }


        }

        //Почати виконання нового потоку   
        void Run()
        {
            Console.WriteLine("Thread " + Thrd.Name + " is beginning.");
            Stopwatch threadTime = new Stopwatch();
            threadTime.Start();
            do
            {
                
                
                Count++;
                if (currentName != Thrd.Name)
                {
                    currentName = Thrd.Name;
                    Console.WriteLine("In thread " + currentName);
                }
            } while (stop == false && Count < 1e9);
            stop = true;
            threadTime.Stop();

            Console.WriteLine("***************************************");
            Console.WriteLine("Thread " + Thrd.Name + " is completed with " + threadTime.ElapsedMilliseconds.ToString() + " ms, " + "and counted to " + Count);
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
        }
    }
}
