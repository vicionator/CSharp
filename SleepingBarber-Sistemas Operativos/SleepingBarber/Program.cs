using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SleepingBarber
{
        class Program
        {
            static int i = 0;
            static int NumClientes = 10;
            static int NumSillas = 3;
            static Queue<int> Items = new Queue<int>();
            static Random r = new Random();

            public static void Clientes()
            {
                for (i = 0; i < NumClientes; i++)
                {
                    lock (Items)
                    {
                        if (Items.Count < NumSillas)
                        {
                            int num = i;
                            Items.Enqueue(num);
                            Console.WriteLine("El cliente numero: " + num + " ha llegado");
                            Monitor.Pulse(Items);
                            Thread.Sleep(r.Next(0,50));
                        }
                        else 
                        {
                            Console.WriteLine("No hay lugar para el cliente numero: " + i);
                            Thread.Sleep(r.Next(0, 50));
                        }
                    }
                }
            }
            public static void Barbero()
            {
                while (true)
                {
                    lock (Items)
                    {
                        if (Items.Count == 0) 
                        {
                            Console.WriteLine("Barbero Dormido, Presione Enter");
                            Console.ReadKey(false);
                        }
                        else
                        {
                            int n = Items.Dequeue();
                            Console.WriteLine("                               Cortando el cabello de cliente numero: " + n);
                            Thread.Sleep(r.Next(2500, 5000));
                        }
                    }
                }
            }
            static void Main(string[] args)
            {

                Thread Cl = new Thread(Clientes);
                Thread Bar = new Thread(Barbero);

                Cl.Start();
                Bar.Start();

                Cl.Join();
                Bar.Join();
            }
        }
    }
