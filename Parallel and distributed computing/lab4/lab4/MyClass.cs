using System;
using System.Diagnostics;

namespace lab4
{
    class MyClass
    {
        public static void MyTask2()
        {
            Stopwatch sw = new Stopwatch();
            do
            {
                sw.Start();
                Console.WriteLine(".......");
            } while (Convert.ToInt32(sw.ElapsedMilliseconds) < 5000);
            sw.Stop();
            Console.WriteLine("5 seconds passed!!!!!!!!!!!!!!!!!");
            Console.WriteLine("MyTask2() method is DONE!!!!!!!!!!!!!!!!!!!");
        }
    }
}
