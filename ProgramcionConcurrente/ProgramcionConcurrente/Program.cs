// See https://aka.ms/new-console-template for more information
using ProgramcionConcurrente;

//ServerClass serverObject = new ServerClass();

//// Create the thread object, passing in the
//// serverObject.InstanceMethod method using a
//// ThreadStart delegate.
//Thread InstanceCaller = new(new ThreadStart(serverObject.IntanceMethod));

//// Start the thread.
//InstanceCaller.Start();

//Console.WriteLine("The Main() thread calls this after "
//    + "starting the new InstanceCaller thread.");

//// Create the thread object, passing in the
//// serverObject.StaticMethod method using a
//// ThreadStart delegate.
//Thread StaticCaller = new(new ThreadStart(ServerClass.StaticMethod));

//// Start the thread.
//StaticCaller.Start();


//Console.WriteLine("The Main() thread calls this after "
//    + "starting the new StaticCaller thread.");

//// Supply the state information required by the task.
//ThreadWithState tws = new("This report displays the number {0}.", 42);

//// Create a thread to execute the task, and then
//// start the thread.
//Thread t = new(new ThreadStart(tws.ThreadProc));
//t.Start();
//Console.WriteLine("Main thread does some work, then waits.");
//t.Join();
//Console.WriteLine(
//    "Independent task has completed; main thread ends.");

//var callBack = (int lineCount) =>
//{
//    Console.WriteLine($"Independent task printed {lineCount} lines.");
//};

//// Supply the state information required by the task.
//ThreadWithState2 tws = new(
//    "This report displays the number {0}.",
//    42,
//    new ExampleCallback(callBack)
//);

//Thread t = new(new ThreadStart(tws.ThreadProc));
//t.Start();
//Console.WriteLine("Main thread does some work, then waits.");
//t.Join();
//Console.WriteLine(
//    "Independent task has completed; main thread ends.");

//// Interrupt a sleeping thread.
//var sleepingThread = new Thread(ExamplePauseInterrupt.SleepIndefinitely);
//sleepingThread.Name = "Sleeping";
//sleepingThread.Start();
//Thread.Sleep(2000);
//sleepingThread.Interrupt();

//Console.WriteLine($"Thread '{Thread.CurrentThread.Name}' .");
//Thread.Sleep(1000);

//sleepingThread = new Thread(ExamplePauseInterrupt.SleepIndefinitely);
//sleepingThread.Name = "Sleeping2";
//sleepingThread.Start();
//Thread.Sleep(2000);
//sleepingThread.Abort();

////Programacion de hilos
//var schedulingThreads = new SchedulingThreads();
//schedulingThreads.RunMultipleThreadsOnDifferentPriorities();

await PrepDesayunoAsincrono.prepararDesayunoAsicronoTareas();


// The example displays the output like the following:
//    The Main() thread calls this after starting the new InstanceCaller thread.
//    The Main() thread calls this after starting the new StaticCaller thread.
//    ServerClass.StaticMethod is running on another thread.
//    ServerClass.InstanceMethod is running on another thread.
//    The instance method called by the worker thread has ended.
//    The static method called by the worker thread has ended.