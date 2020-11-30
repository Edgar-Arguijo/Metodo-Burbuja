using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------Metodo Burbuja------------------------------------");
            Console.WriteLine("");
            //Arreglo con un tamaño de 10 datos
            int[] Arreglo = new int [10];
            //Declaracion de objeto
            Burbuja Obj1 = new Burbuja();

            Obj1.Insertar(Arreglo,4);
            Obj1.Insertar(Arreglo,8);
            Obj1.Insertar(Arreglo,90);
            Obj1.Insertar(Arreglo,23);
            Obj1.Insertar(Arreglo,1);
            Obj1.Insertar(Arreglo,67);
            Obj1.Insertar(Arreglo,54);
            Obj1.Insertar(Arreglo,16);

            Console.Write("---------------------------------- Elementos aun no ordenados: --------------------------");
            Console.WriteLine();
            Obj1.Mostrar(Arreglo);
            Obj1.Intercambio(Arreglo);
            Console.Write("----------------------------- Elementos Ordenados de Menor a Mayor: ----------------------");
            Console.WriteLine();
            Obj1.Mostrar(Arreglo);
            Console.ReadKey();
        }

        }
    }
