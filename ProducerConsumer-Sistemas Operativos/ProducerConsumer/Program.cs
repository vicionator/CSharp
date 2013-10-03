using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static int i = 0;
        static int NumProcesos = 10;
        static Queue<int> Items = new Queue<int>();
        static Random r = new Random();

        public static void Produce_Item() 
        {
            for (i = 0; i < NumProcesos; i++)
            {
                lock (Items)
                {
                    int num = r.Next(10);
                    Console.WriteLine("Produciendo Numero: " + num);
                    Items.Enqueue(num);
                    Monitor.Pulse(Items);
                    Thread.Sleep(r.Next(250));
                    
                }
            }
        }
        public static void Consume_Item() 
        {
            while (true)
            {
                lock (Items)
                {
                    if (Items.Count != 0)
                    {
                        int n = Items.Dequeue();
                        Console.WriteLine("                                 Consumiendo Numero: " + n);
                        Thread.Sleep(r.Next(500,1000));

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            
            Thread Produciendo = new Thread(Produce_Item);
          //  Thread Produciendo2 = new Thread(Produce_Item);
            Thread Consumiendo = new Thread(Consume_Item);
           // Thread Consumiendo2 = new Thread(Consume_Item);

            Produciendo.Start();
        //    Produciendo2.Start();
            Consumiendo.Start();
          //  Consumiendo2.Start();

            Produciendo.Join();
         //   Produciendo2.Join();
            Consumiendo.Join();
          //  Consumiendo2.Join();
        }
    }
}
