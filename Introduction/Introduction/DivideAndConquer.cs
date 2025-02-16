using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction; 

public  class DivideAndConquer
{
    public static void Main(string[] args) {


        int[] arr = { 10, 20, 30, 40 };
        int sum1 = 0;
        int sum2 = 0; 

        Thread thread1 = new Thread(() => sum1 = sumArray(arr, 0,arr.Length/2));
        Thread thread2 = new Thread(() => sum2 = sumArray(arr, arr.Length / 2, arr.Length));
        

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Total sum result is : {sum1+sum2}");
    
    }



    //DIVDE AND CONQUER APPROACH.
    public static int sumArray(int[] arr, int start, int end)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum+= arr[i];
        }

        return sum; 
    }


    //LINEAR APPROACH.
    public static int sum(IEnumerable<int> nums) {
        var sum = 0;

        foreach (var x in nums)
        {
            sum+= x;
        }

        return sum; 

    } 
}
/*
 * Divide the chunk into multiple portions. 
 */
