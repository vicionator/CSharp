using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DinnerPhilosopher
{
    class Program
    {
        static int N = 5;
        static bool [] Tenedores = new bool[N];
        static Random r = new Random();

        static void Main(string [] args)
        {

            Thread[] Filosofo = new Thread[N];

            for (int i = 0; i < N; i++)
            {
                int m = i;
                Tenedores[i] = true;
                Filosofo[i] = new Thread(() => GetTenedor(m));
            }

            foreach (Thread t in Filosofo)
            {
                t.Start();
            }
        }
        public static void GetTenedor(int i)
        {
            if (i == 0)
            {
                while (!Tenedores[i])
                {
                    Console.WriteLine("Filosofo #" + (i + 1) + " esta esperando el tenedor " + (i + 1));
                    Thread.Sleep(r.Next(1000, 2000));
                }
                Console.WriteLine("Filosofo #" + (i + 1) + " tomo el tenedor " + (i + 1));
                Tenedores[i] = false;
                while (!Tenedores[N - 1]) 
                {
                    Console.WriteLine("Filosofo #" + (i + 1) + " esta esperando el tenedor " + (N));
                    Thread.Sleep(r.Next(1000, 2000));
                }
                Console.WriteLine("Filosofo #" + (i + 1) + " tomo el tenedor " + (N));
                Tenedores[N - 1] = false;
                Console.WriteLine("Filosofo #" + (i + 1) + " esta comiendo.");
                Tenedores[i] = true;
                Tenedores[N - 1] = true;
                Console.WriteLine("Filosofo #" + (i + 1) + " solto los tenedores " + (i + 1) + " y " + (N));
            }
            else 
            {
                while (!Tenedores[i])
                {
                    Console.WriteLine("Filosofo #" + (i + 1) + " esta esperando el tenedor " + (i + 1));
                    Thread.Sleep(r.Next(1000, 2000));
                }
                Console.WriteLine("Filosofo #" + (i + 1) + " tomo el tenedor " + (i + 1));
                Tenedores[i] = false;
                while (!Tenedores[i - 1])
                {
                    Console.WriteLine("Filosofo #" + (i + 1) + " esta esperando el tenedor " + (i));
                    Thread.Sleep(r.Next(1000, 2000));
                }
                Console.WriteLine("Filosofo #" + (i + 1) + " tomo el tenedor " + (i));
                Tenedores[i - 1] = false;
                Console.WriteLine("Filosofo #" + (i + 1) + " esta comiendo.");
                Tenedores[i] = true;
                Tenedores[i - 1] = true;
                Console.WriteLine("Filosofo #" + (i + 1) + " solto los tenedores " + (i + 1) + " y " + (i));
            }
        }
    }
}
