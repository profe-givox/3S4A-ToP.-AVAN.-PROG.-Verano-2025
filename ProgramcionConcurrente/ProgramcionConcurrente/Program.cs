// See https://aka.ms/new-console-template for more information
using ProgramcionConcurrente;

ServerClass serverObject = new ServerClass();

// Create the thread object, passing in the
// serverObject.InstanceMethod method using a
// ThreadStart delegate.
Thread InstanceCaller = new(new ThreadStart(serverObject.IntanceMethod));

// Start the thread.
InstanceCaller.Start();

Console.WriteLine("The Main() thread calls this after "
    + "starting the new InstanceCaller thread.");

// Create the thread object, passing in the
// serverObject.StaticMethod method using a
// ThreadStart delegate.
Thread StaticCaller = new(new ThreadStart(ServerClass.StaticMethod));

// Start the thread.
StaticCaller.Start();

Console.WriteLine("The Main() thread calls this after "
    + "starting the new StaticCaller thread.");





// The example displays the output like the following:
//    The Main() thread calls this after starting the new InstanceCaller thread.
//    The Main() thread calls this after starting the new StaticCaller thread.
//    ServerClass.StaticMethod is running on another thread.
//    ServerClass.InstanceMethod is running on another thread.
//    The instance method called by the worker thread has ended.
//    The static method called by the worker thread has ended.