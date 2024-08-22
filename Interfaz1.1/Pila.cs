using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1._1
{
    public class Pila : IColleccion
    {
        private object[] array;
        private int contador = 0;
        private int tamañoInicial = 10;

        public Pila()
        {
            array = new object[tamañoInicial]; 
            contador = 0;
        }


        public bool añadir(object obj) 
        {
            if (array.Length == contador)
            {
                Array.Resize(ref array, array.Length*2); // redimensiona el tamaño del array
            }
            array[contador++] = obj; // aumenta el contador y agrega el obj al array

            if (array[contador - 1].Equals(obj)) //compara el objeto agregado con la posición -1
            {
                Console.WriteLine("El objeto se agrego correctamente.");
                return true;
            }
            else
            {
                Console.WriteLine("El objeto NO se agrego.");
                return false;
            }
           
        }

      

        public bool estaVacia()
        {
            if(contador == 0)
            {
                   return true;

            } else { return false; }
        }

        public object extraer()
        {
            if (estaVacia())
            {
                throw new Exception("El array está vacío.");
            }

            object item = array[contador - 1];
            array[contador] = null;  // limpia el lugar del array
            return item;
        }

        public object primero()
        {
            if (estaVacia())
            {
                throw new Exception("El array está vacío.");
            }

            return array[contador-1];
        }
    }
       
}
