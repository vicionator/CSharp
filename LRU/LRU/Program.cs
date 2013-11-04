using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = new int[] { 0, 1, 2, 3, 2, 1, 0, 3, 2, 3 };

            int[,] arreglo = new int[4, 4];

            for (int i = 0; i < k.Length; i++)
            {
                for (int j = 0; j < arreglo.GetLength(0); j++)
                {
                    arreglo[k[i], j] = 1;
                }
                for (int z = 0; z < arreglo.GetLength(1); z++)
                {
                    arreglo[z, k[i]] = 0;
                }
                ImprimeArreglo(arreglo,k[i]);
            }


            //Console.WriteLine(LeeRenglon(arreglo));
            Console.ReadLine();
            
        }

        public static void ImprimeArreglo(int[,] Arr, int access) 
        {
            int d1 = Arr.GetLength(0);
            int d2 = Arr.GetLength(1);

            Console.WriteLine("Page frame K = " + access);
            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2; j++)
                {
                    Console.Write(Arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int LeeRenglon(int[,] array) 
        {
            int menor = 0;
            string wow;
            int[] LeastUsed = new int[4];
            for (int i = 0; i < 4; i++)
            {
                wow = String.Empty;
                for (int j = 0; j < 4; j++)
                {
                    wow += array[i, j].ToString();
                }
                LeastUsed[i] = ToDecimal(wow);
            }
            menor = Array.IndexOf(LeastUsed, LeastUsed.Min());
            return menor;
        }
        public static int ToDecimal(string bin)
        {
            long l = Convert.ToInt64(bin, 2);
            int i = (int)l;
            return i;
        }
    }
}
