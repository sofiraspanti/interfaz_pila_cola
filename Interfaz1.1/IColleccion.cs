using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1._1
{
    public interface IColleccion
    {
        bool estaVacia(); //devuelve true si la colección está vacía y false en caso contrario.

        Object extraer(); // devuelve y elimina el primer elemento de la colección

        Object primero(); // devuelve el primer elemento de la colección

        bool añadir(Object obj); // añade un objeto por el extremo que corresponda, y devuelve true si
                                 // se ha añadido y false en caso contrario


        



    }
}
