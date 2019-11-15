using System;

namespace CountingValleys
{
    class Program
    {
        static int CountingValleys(int n, string s) {
            char uphhill = 'U';
            char downhill = 'D';
            int distanciaNivelDelMar = 0;
            bool estaEnValle = false;
            int vallesRecorridos = 0;

            for (int i = 0; i < n; i++)
            {
                char pasoDado = s[i];
                if (pasoDado.Equals(downhill)) 
                {
                    distanciaNivelDelMar--;
                    if (!estaEnValle && distanciaNivelDelMar == -1)
                    {
                        estaEnValle = true;
                    }
                }
                else
                {
                    if (pasoDado.Equals(uphhill)) 
                    {
                        distanciaNivelDelMar++;
                        if (estaEnValle && distanciaNivelDelMar == 0)
                        {
                            estaEnValle = false;
                            vallesRecorridos++;
                        }
                    }
                }
            }

            return vallesRecorridos;
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = CountingValleys(n, s);

            Console.WriteLine(result);
        }
    }
}
