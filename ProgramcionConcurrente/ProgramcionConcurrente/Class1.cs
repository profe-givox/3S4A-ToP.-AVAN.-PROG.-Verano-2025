using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramcionConcurrente
{
    internal class ServerClass
    {
        // The method that will be called when the thread is started.
        public void IntanceMethod()
        {
            Console.WriteLine(
            "ServerClass.InstanceMethod is running on another thread.");

            // Simulate some work by sleeping for 2 seconds.
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Thread has finished executing.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(
            "ServerClass.StaticMethod is running on another thread.");
            // Simulate some work by sleeping for  seconds.
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Thread has finished executing.");
        }
    }
}
