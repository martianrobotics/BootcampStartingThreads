using System;
using System.Threading;

namespace BootcampStartingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            // no parameters
            Thread workerThread = new Thread(StartThread);
            Console.WriteLine("Main Thread Id {0}",
                Thread.CurrentThread.ManagedThreadId.ToString());
            workerThread.Start();

            // using parameter
            Thread workerThread2 = new Thread(ParameterizedStartThread);
            // the answer to life, the universe, and everything, is 42, obviously
            workerThread2.Start(42);
            Console.ReadLine();
        }

        public static void StartThread()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Thread value {0} running on Thread Id {1}",
                    i.ToString(),
                    Thread.CurrentThread.ManagedThreadId.ToString());
        }

        public static void ParameterizedStartThread(object value)
        {
            Console.WriteLine("Thread passed value {0} running on Thread Id {1}",
                value.ToString(),
                Thread.CurrentThread.ManagedThreadId.ToString()
                );
        }
    }
}
