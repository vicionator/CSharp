using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Procesos = new int[] { 212, 417, 112, 426 };
            int[] Memoria = new int[] { 100, 500, 200, 300, 600 };
            int posicion = 0;
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

            for (int i = 0; i < Procesos.Length;)
            {
                int temp = 0;
                for (int j = posicion; j < Memoria.Length;j++)
                {
                    temp++;
                    if (Memoria[j] >= Procesos[i])
                    {
                        Console.Write("\n\nAlocando Proceso {0} de posicion {1} en Memoria {2} en posicion {3}", Procesos[i], i + 1, Memoria[j], j + 1);
                        Memoria[j] -= Procesos[i];
                        Console.Write("\n\nMemoria restante en posicion {0} = {1}", j + 1, Memoria[j]);
                        if (j == Memoria.Length - 1)
                        {
                            posicion = 0;
                        }
                        else
                        {
                            posicion = j;
                        }
                        i++;
                        break;
                    }
                    if (j == Memoria.Length - 1 && Memoria[j]<Procesos[i])
                    {
                        posicion = 0;
                    }
                    if (temp==5) 
                    {
                        Console.Write("\n\nNo hay memoria suficiente para el proceso {0}", Procesos[i]);
                        i++;
                        break;
                    }
                }
            }
            Console.Write("\n\nMemoria restante: ");
            foreach (int m in Memoria)
            {
                Console.Write("{0} ", m);
            }
            Console.ReadKey();
        }
    }
}
