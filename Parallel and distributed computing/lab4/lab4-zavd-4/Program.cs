using System;
using System.Threading.Tasks;

namespace lab4_zavd_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is starting.");
            var sum = 0;
            Parallel.Invoke(() =>
            {
                Console.WriteLine("\nFirst parametr to Invoke method");
                for (int i = 0; i < 101; i++)
                {
                    sum += i;
                }
                Console.WriteLine("sum = {0}", sum);
            }, () =>
            {
                Console.WriteLine("\nSecond parametr to Invoke method");
                for (int i = 0; i < 201; i++)
                {
                    sum += i;
                }
                Console.WriteLine("sum = {0}", sum);
            });
            Console.WriteLine("\nMain is done.");
            Console.ReadLine();
        }
    }
}
