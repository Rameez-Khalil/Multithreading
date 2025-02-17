using System.Net.Http.Headers;

class Program
{
    private static int number = 0; 
    private static object lockObject = new object(); //this locks our critical section.


    public static void Main(string[] args)
    {
        ThreadSynchronizationSafe(); 
    }





    //THREAD SYNCRHONIZATION EXAMPLE 1. (Non atomic operation, and non consistent result due to race condition).

    //increment the counter.
    public static void counter()
    {
        for (int i = 0; i < 10000; i++)
        {
            number++;
            //non atomic operation (First Read and Second increment) and might not result in accurate result.
            //each variable instantiate ith variable separately.
            // number is the shared resource.
        }
   
    }
    //Increment the counter through threads.
    public static void ThreadSynchronization()
    {

        Thread thread1 = new Thread(counter);
        Thread thread2 = new Thread(counter);

        thread1.Start();
        thread2.Start();
        thread1.Join(); 
        thread2.Join();

        Console.WriteLine($"Final value : {number}" );
    }


    //THREAD SYNCRHONIZATION EXAMPLE 2. (Lock Object, Thread safe).

    public static void CounterThreadSafe()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObject) //try catch finally builtin, the finally releases the lock always.
            {
                number++;
            }
        }
    }
    public static void ThreadSynchronizationSafe()
    {
        Thread thread1 = new Thread (CounterThreadSafe);
        Thread thread2 = new Thread(CounterThreadSafe);

        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();

        Console.WriteLine($"The final value: {number}");
    }

}



/*
 * 
 * TRHREAD SYNCHRONIZATION - 
 * 
 * When multiple threads are using a shared resource.
 * 
 * 
 * RACE CONDITION - When multiple threads try to retrieve the shared resouce.
 */