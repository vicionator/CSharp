using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Procesos = new int[] { 212, 417, 112, 426 };
            int[] Memoria = new int[] { 100, 500, 200, 300, 600 };

            Console.Write("Procesos: ");

            foreach (int p in Procesos)
            {
                Console.Write("{0} ", p);
            }

            Console.Write("\nMemoria disponible: ");
            foreach (int m in Memoria)
            {
                Console.Write("{0} ", m);
            }

            Ordenar(Memoria);

            for (int i = 0; i < Procesos.Length; i++)
            {
                for (int j = 0; j < Memoria.Length; j++)
                {
                    if (Memoria[j] >= Procesos[i]) 
                    {
                        Console.Write("\n\nAlocando Proceso {0} en Memoria {1}", Procesos[i], Memoria[j]);
                        Memoria[j] -= Procesos[i];
                        Console.Write("\n\nMemoria restante = {0}", Memoria[j]);
                        break;
                    }
                    if (j == Memoria.Length-1) 
                    {
                        Console.Write("\n\nNo hay memoria suficiente para el proceso {0}", Procesos[i]);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        public static int[] Ordenar(int[] temp) 
        {
            int t;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length-1; j++)
                {
                    if (temp[j] > temp[j + 1]) 
                    {
                        t = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = t;
                    }
                }
            }
            return temp;
        }
    }
}
