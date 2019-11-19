using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void Staircase(int n) {
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int diferencia = n-i;
                for (int j = 0; j < diferencia-1; j++)
                {
                    resultado.Append(" ");
                }

                for (int j = diferencia; j <= n; j++)
                {
                    resultado.Append("#");
                }

                if (diferencia > 1)
                {
                    resultado.Append("\n");
                }
                
            }
            Console.Write(resultado.ToString());

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);
        }
    }
}
