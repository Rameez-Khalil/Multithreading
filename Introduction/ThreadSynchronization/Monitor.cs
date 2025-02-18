using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization; 

public class Monitor
{
}


/*
 * MONITOR 
 *  - A block of code that blocks the access to other threads when the section is currently in use. 
 *  - This is going to make an exclusive lock.
 *  -  Monitor.Enter(lock) and Monitor.Exit() SO this is actually done through compilation after using lock.
 *  
 *  
 *  MUTEX - Thread synchronization mechanism. Similar to lock.
 *  
 *  Thread affinity - Any lock that has been acquired by the same thread has to be released by the same thread.
 *  
 *  Thread Safe - A function is said to be a thread safe function when it allows concurrent operations leading to expected result !(race conditions, inconsistent data, or unexpected behavior).
 *  
 *  
 *  
 *  
 */
