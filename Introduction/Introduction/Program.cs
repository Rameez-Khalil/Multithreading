class Program
{
    //public static void Main(string[] args)
    //{

    //    //Create a new thread.
    //    Thread thread1 = new Thread(threadScheduler);
    //    Thread thread2 = new Thread(threadScheduler);



    //    thread1.Name = "Theead1";
    //    thread2.Name = "Thread2"; 


    //    thread1.Start();
    //    thread2.Start();
    //}


    static void WriteThreadId()
    {
        Console.WriteLine(Thread.CurrentThread.Name);
    }




    //THREAD SCHEDULER DEMONSTRATION.
    public static void threadScheduler()
    {
        for (int i = 0; i < 100; i++)
        {
            WriteThreadId();
            Thread.Sleep(50);
        }
    }

    
}



/*
 * CPU, THREAD, AND THREAD SCHEDULER.
 * 
 * CPU - CPU can only run threads, and application always have a thread.
 *      when the application starts execution, then the thread is assigned to the CPU, via thread scheduler.
 *      To the CPU nothing exists but a thread.
 *      Time_slice is the time during which the thread is assigned to the CPU. - It's not under devs control.
 *      
 *      
 *      Thread scheduler is independent of the applications exists, it only cares about the total number of threads.
 *      
 *      When there are multiple threads in an application, then that application is termed as 'MultiThreading' application.
 *      
 *   
 * 
 */



/*
 * BASIC SYNTAX.
 *  Create a thread object.
 *  Assign a task (pass the function).
 *  Start the thread.
 *  
 */


/*
 * WHY DO WE NEED A THREAD - DIVIDE AND CONQUER.
 * 
 */

