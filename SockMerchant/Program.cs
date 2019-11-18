using System.Collections.Generic;
using System;

namespace SockMerchant
{
    class Program
    {
        static int SockMerchant(int n, int[] ar) {
            Dictionary<int, int> numeros = new Dictionary<int, int>();
            int numeroParejas = 0;
            for (int i = 0; i < n; i++)
            {
                int elementoEnLista = ar[i];
                if (numeros.ContainsKey(elementoEnLista)) 
                {
                    numeros[elementoEnLista] += 1; 
                }
                else {
                    numeros.Add(elementoEnLista, 1);
                }

            }

            foreach (var item in numeros)
            {
                numeroParejas += item.Value / 2;
            }

            return numeroParejas;
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
    
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SockMerchant(n, ar);

            Console.WriteLine(result);

        }
    }
}
