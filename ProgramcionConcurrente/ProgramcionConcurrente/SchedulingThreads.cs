using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramcionConcurrente
{
    internal class SchedulingThreads
    {
        public void RunMultipleThreadsOnDifferentPriorities()
        {
            var lstHilos = new List<Thread>(9);
            for (int i = 0; i < 9; i++){
                var thread = new Thread( () => 
                                        { 
                                                   new ThreadWithCallback(Callback).Process();
                                        } 
                                        );
                if (i > 3)
                {
                    thread.Priority = ThreadPriority.Highest;
                }
                else
                    thread.Priority = (ThreadPriority)i;
                lstHilos.Add(thread);
            }
            lstHilos.ForEach(hilo => hilo.Start());
        }
        public void Callback(ThreadPriority threadPriority)
        {
            Console.WriteLine($"Callback in {threadPriority} priority. " +
                $"\t\t ThreadId: {Thread.CurrentThread.ManagedThreadId}.");
        }

    }

    public class ThreadWithCallback
    {
        public ThreadWithCallback(Action<ThreadPriority> callback)
        {
            this.callback = callback;
        }
        public Action<ThreadPriority> callback;
        public void Process()
        {
            Console.WriteLine($"Entered process in " +
                $"{Thread.CurrentThread.Priority} priority.  " +
                $"\t\t ThreadId: {Thread.CurrentThread.ManagedThreadId}.");
            Thread.Sleep(1000);
            Console.WriteLine($"Finished process in {Thread.CurrentThread.Priority} priority." +
                $" \t\t ThreadId: {Thread.CurrentThread.ManagedThreadId}.");

            if (callback != null)
            {
                callback(Thread.CurrentThread.Priority);
            }
        }
    }
}
