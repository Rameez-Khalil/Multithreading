class Program
{
    public static async Task Main(string[] args)
    {
        var task = Task.Run(Work);
        await task; 


        //TASK WHEN RETURNING A VALUE.
        var taskInteger =  Task.Run(IntegerWork);
        await taskInteger;
        Console.WriteLine(taskInteger.Result);

        
        
    }




    //VOID WORK.
    public static void Work()
    {
        Console.WriteLine("Saaray kaam main hi karun!");
        Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
    }

    //WORK THAT RETURNS INT.
    public static int IntegerWork()
    {
        Console.WriteLine("Han main hi karunga kaam!");
        Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

        int value = 10; 
        return value;
    }
}



/*
 * MULTITHREADING VS ASYNC PROGRAMMING.
 * 
 * Multithreading: Works by dividing tasks into multiple threads (useful for CPU-bound tasks like gaming, simulations).
 * Async Programming: Works by **offloading I/O-bound tasks** (like API calls, DB queries) so the main thread is free to handle other work.
 * 
 * 
 * TASK.
 * Task task = new Task(Work<Delegate>).
 * task.start()  // Creates a Task manually (not recommended). Instead, use Task.Run()
 * 
 * 
 * A Task is an abstraction over a unit of work that may run on a separate thread or not (it depends on how it's scheduled).
    A Thread is a physical execution unit that processes code.
 * 
 */
