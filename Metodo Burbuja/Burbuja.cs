using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Burbuja
{
    class Burbuja
    {
        //variable privada para las pocision
        private int Pos;
        //Variable auxiliar privada
        private int aux;
        //Constructor
        public Burbuja()
        {
            Pos = 0;
        }
        //Metod para Insertar elementos
        public int Insertar(int[] valores, int elemento)
        {
            valores[Pos] = elemento;
            Pos++;
            return (Pos);
        }
        // Metodo para Intercambiar posiciones(Metodo Burbuja)
        public void Intercambio(int[] valores)
        {
            for(int i= 0;i < Pos; i++)
            for(int j = Pos - 1;j > i; j--)
            {
            	if(valores[j-1] > valores[j])
            	{
            		aux=valores[j-1];
            		valores[j-1] = valores[j];
            		valores[j] = aux;
            	}
            }
        }
               //Metodo para Mostrar
                public void Mostrar(int[] valores)
                {
                    //arreglo para mostrar valores
                    for (int i = 0; i <=7; i++)
                    {
                        //Muestra los valores del arreglo
                        Console.WriteLine("Elemento[ " + i + " ]" + " = " +valores[i]);
                    }
                }
        
          }
      }