using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n,suma = 0;
            int[] v = new int[50];
            float media;
            Console.Write("Introduceti numarul de valori: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Valoarea {0}: ", i+1);
                v[i] = Convert.ToInt32(Console.ReadLine());
                suma += v[i];
            }

            media = (float)suma / n;

            Console.WriteLine("\n Media aritmetica a valorilor introduseee este : {0} \n", media);
        }
    }
}
