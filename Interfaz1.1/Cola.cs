using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1._1
{
    internal class Cola : IColleccion
    {
        List<object> elementos = new List<object>(); // estructua FIFO, 1ro en entrar, 1ro en salir 

        public bool añadir(object obj)
        {
            elementos.Add(obj);

            if (elementos.Contains(obj))
            {
                Console.WriteLine("El valor se ha agregado correctamente");
                return true;
            } else
            {
                Console.WriteLine("El valor NO pudo agregarse a la lista");
                return false;
            }
        }

        public bool estaVacia()
        {
            if (elementos.Count == 0)
            {
                return true;
            } else return false;
        }

        public object extraer()
        {
            if (estaVacia())
            {
                throw new InvalidOperationException("La lista está vacía.");

            } else
            {
                object obj = elementos[0]; // extraigo el primer elemento
                elementos.RemoveAt(0);  //remuevo el elemento
                return obj;  //retorno el objeto extraido
            }
        }

        public object primero()
        {
            if (estaVacia())
            {
                throw new InvalidOperationException("La lista está vacía");
            } else
            {
                object obj = elementos[0];
                return obj;
            }
        }
    }
}
