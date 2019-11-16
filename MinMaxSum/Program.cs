using System;
using System.Collections;

namespace MiniMaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr) {
            Array.Sort(arr);
            long minimo = 0;
            long maximo = 0;
            for (int i = 0; i <= 3; i++)
            {
                minimo += arr[i];    
            }
            for (int i = 1; i <= 4; i++)
            {
                maximo += arr[i];
            }
            Console.WriteLine(String.Format("{0} {1}", minimo, maximo));
        }
        
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
