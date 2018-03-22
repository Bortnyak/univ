using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab4
{
    class DemoTask
    {
        public static void MyTask()
        {
            Console.WriteLine("MyTask() is started.");
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("In the method MyTask() counter = " + count);
            }
            Console.WriteLine("MyTask() DONE");
        }
    }
}
