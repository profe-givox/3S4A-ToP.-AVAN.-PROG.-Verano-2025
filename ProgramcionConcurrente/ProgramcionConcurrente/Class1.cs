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
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Thread has finished executing method instance.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(
            "ServerClass.StaticMethod is running on another thread.");
            // Simulate some work by sleeping for  seconds.
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Thread has finished executing method static .");
        }
    }

    // The ThreadWithState class contains the information needed for
    // a task, and the method that executes the task.
    //
    public class ThreadWithState
    {
        // State information used in the task.
        private string _boilerplate;
        private int _numberValue;

        // The constructor obtains the state information.
        public ThreadWithState(string text, int number)
        {
            _boilerplate = text;
            _numberValue = number;
        }

        // The thread procedure performs the task, such as formatting
        // and printing a document.
        public void ThreadProc()
        {
            Console.WriteLine(_boilerplate, _numberValue);
        }
    }

    // The ThreadWithState2 class contains the information needed for
    // a task, the method that executes the task, and a delegate
    // to call when the task is complete.
    public class ThreadWithState2
    {
        // State information used in the task.
        private string _boilerplate;
        private int _numberValue;

        // Delegate used to execute the callback method when the
        // task is complete.
        private ExampleCallback _callback;

        // The constructor obtains the state information and the
        // callback delegate.
        public ThreadWithState2(string text, int number,
            ExampleCallback callbackDelegate)
        {
            _boilerplate = text;
            _numberValue = number;
            _callback = callbackDelegate;
        }

        // The thread procedure performs the task, such as
        // formatting and printing a document, and then invokes
        // the callback delegate with the number of lines printed.
        public void ThreadProc()
        {
            Console.WriteLine(_boilerplate, _numberValue);
            _callback?.Invoke(1);
        }
    }

    // Delegate that defines the signature for the callback method.
    public delegate void ExampleCallback(int lineCount);

    public class ExamplePauseInterrupt {

        public static void Main() {
            // Interrupt a sleeping thread.
            var sleepingThread = new Thread(ExamplePauseInterrupt.SleepIndefinitely);
            sleepingThread.Name = "Sleeping";
            sleepingThread.Start();
            Thread.Sleep(2000);
            sleepingThread.Interrupt();

            Thread.Sleep(1000);

            sleepingThread = new Thread(ExamplePauseInterrupt.SleepIndefinitely);
            sleepingThread.Name = "Sleeping2";
            sleepingThread.Start();
            Thread.Sleep(2000);
            sleepingThread.Abort();
        }

        public static void SleepIndefinitely()
        {
            Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' about to sleep indefinitely.");
            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException)  
            {
                Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' awoken.");
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' aborted.");
            }
            finally
            {
                Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' executing finally block.");
            }
            Console.WriteLine($"Thread '{Thread.CurrentThread.Name} finishing normal execution.");
            Console.WriteLine();
        }

    }

}
