using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bloque[] Block = new Bloque[6];
            File[] Archivo = new File[3];

            for (int i = 0; i < Block.Length; i++)
            {
                Block[i] = new Bloque();
                Block[i].Disponibilidad = true;
                Block[i].Espacio = 100;
            }

            Archivo[0] = new File();
            Archivo[0].Nombre = "wow";
            Archivo[0].Tamaño = 85;

            Archivo[1] = new File();
            Archivo[1].Nombre = "yeah";
            Archivo[1].Tamaño = 125;

            Archivo[2] = new File();
            Archivo[2].Nombre = "who";
            Archivo[2].Tamaño = 253;

            Console.WriteLine("Espacios Disponibles");
            foreach (Bloque b in Block)
            {
                Console.WriteLine(b.Espacio);
            }
            Console.WriteLine();

            Console.WriteLine("Archivos a meter");
            foreach (File a in Archivo)
            {
                Console.WriteLine("Nombre: " + a.Nombre + " Tamaño: " + a.Tamaño);
            }
            Console.WriteLine();
            for (int i = 0; i < Archivo.Length; i++)
            {
                for (int j = 0; j < Block.Length; j++)
                {
                    if (Block[j].Disponibilidad == true) 
                    {
                        Block[j].Nombre = Archivo[i].Nombre;

                        if (Block[j].Espacio - Archivo[i].Tamaño >= 0) 
                        {
                            Block[j].Espacio -= Archivo[i].Tamaño;
                            Block[j].Disponibilidad = false;
                            break;
                        }
                        else if (Block[j].Espacio - Archivo[i].Tamaño < 0) 
                        {
                            Block[j].Espacio = 0;
                            Archivo[i].Tamaño -= 100;
                            Block[j].Disponibilidad = false;
                        }
                    }
                }
            }
            Console.WriteLine("Bloque resultantes");
            foreach (Bloque b in Block)
            {
                Console.WriteLine("Nombre de archivo almacenado: " + b.Nombre + " Espacio disponible: " + b.Espacio + " Disponibilidad: " + b.Disponibilidad);
            }
            Console.ReadKey();
        }
    }
}
