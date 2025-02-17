using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization; 

public class TicketCounter
{
    private static int ticketCounter = 10; 
    private static readonly object lockObject = new object();


    //decreasing mechanism.
    public static void TicketBook()
    {
        lock (lockObject)
        {
            if (ticketCounter > 0)
            {
                ticketCounter--; //non atomic operation
                Console.WriteLine($"Ticket Count {ticketCounter} Booked By {Thread.CurrentThread.Name}");
            }
            else
            {
                Console.WriteLine("No tickets available");
            }
        }
        
        
    }


    //logic for threads.
    public static void BookTicket(int users)
    {

        Thread[] threads = new Thread[users];
        for(int i=0; i<users; i++)
        {
            threads[i] = new Thread(TicketBook); 
            threads[i].Name = $"Thread-{i+1}"; 
            threads[i].Start();
        }

        foreach (var thread in threads) 
        {
            thread.Join();
        }

        Console.WriteLine("Book Ticket Ran");
    }





}
