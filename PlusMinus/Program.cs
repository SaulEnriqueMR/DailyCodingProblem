using System;

namespace PlusMinus
{
    class Program
    {
        static void PlusMinus(int[] arr) {
            int numeroDeNegativos = 0;
            int numeroDeCero = 0;
            int numeroDePositivos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int numero = arr[i];
                if (numero < 0)
                {
                    numeroDeNegativos++;
                }
                else {
                    if (numero > 0)
                    {
                        numeroDePositivos++;
                    }
                    else
                    {
                        numeroDeCero++;
                    }
                }
            }
            
            Console.WriteLine((Double)numeroDePositivos / arr.Length);
            Console.WriteLine((Double)numeroDeNegativos / arr.Length);
            Console.WriteLine((Double)numeroDeCero / arr.Length);
            
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            PlusMinus(arr);
        }
    }
}
