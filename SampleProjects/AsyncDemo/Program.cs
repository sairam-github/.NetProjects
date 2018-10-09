using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task t = Task.Run(() => LongRunningTask());
            // t.Wait();

            LongRunningTask();
            Console.WriteLine("Long running task is finished.");
        }

        static void LongRunningTask()
        {
            int temp = 1;
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(temp++);

                if (temp == 1000)
                {
                    break;
                }
            }
        }
    }
}
