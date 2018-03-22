using System;
using System.Diagnostics;

namespace lab4_zavd_1
{
    class MyClass
    {
        public static void MyTask2()
        {
            Console.WriteLine("MyTask2() method is started");
            Stopwatch sw = new Stopwatch();
            do
            {
                sw.Start();
                Console.WriteLine(".......");
            } while (Convert.ToInt32(sw.ElapsedMilliseconds) < 200);
            sw.Stop();
            Console.WriteLine("5 seconds passed!!!!!!!!!!!!!!!!!");
            Console.WriteLine("MyTask2() method is DONE!!!!!!!!!!!!!!!!!!!");
        }
    }
}
