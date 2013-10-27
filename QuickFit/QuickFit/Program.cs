using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Procesos = new int[] { 80, 150, 372, 245,100 };
            Espacio[] Memo= new Espacio[3];

            Memo[0] = new Espacio();
            Memo[0].Vi = 1;
            Memo[0].Vf = 100;
            Memo[0].espacio = 100;

            Memo[1] = new Espacio();
            Memo[1].Vi = 101;
            Memo[1].Vf = 300;
            Memo[1].espacio = 500;

            Memo[2] = new Espacio();
            Memo[2].Vi = 301;
            Memo[2].Vf = 500;
            Memo[2].espacio = 400;


            Console.Write("Procesos: ");

            foreach (int p in Procesos)
            {
                Console.Write("{0} ", p);
            }

            Console.Write("\nMemoria disponible por bloques: ");
            for (int i = 0; i < Memo.Length; i++)
            {
                Console.Write("\nEntre {0} y {1} hay {2}", Memo[i].Vi, Memo[i].Vf, Memo[i].espacio);
            }

            for (int i = 0; i < Procesos.Length; i++)
            {
                for (int j = 0; j < Memo.Length; j++)
                {
                    if (Procesos[i] >= Memo[j].Vi && Procesos[i] <= Memo[j].Vf) 
                    {
                        if (Memo[j].espacio >= Procesos[i]) 
                        {
                            Console.Write("\n\nAlocando proceso {0} en entre bloques {1} y {2}", Procesos[i], Memo[j].Vi, Memo[j].Vf);
                            Memo[j].espacio -= Procesos[i];
                            Console.Write("\n\nMemoria restante entre bloques {0} y {1} = {2}", Memo[j].Vi, Memo[j].Vf, Memo[j].espacio);
                            break;
                        }
                    }
                    if (j == Memo.Length - 1)
                    {
                        Console.Write("\n\nNo hay memoria suficiente para el proceso {0}", Procesos[i]);
                        break;
                    }
                }
            }
            Console.Write("\n\nMemoria restante entre bloques: ");
            for (int i = 0; i < Memo.Length; i++)
            {
                Console.Write("\nEntre {0} y {1} hay {2}", Memo[i].Vi, Memo[i].Vf, Memo[i].espacio);
            }
            Console.ReadKey();
        }
    }
}
