using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
 public class Cliente : Persona {

        public Cliente(string _nombre, string _apepat, string _apemat, int _dni) {

            Nombre = _nombre;
            ApePat = _apepat;
            ApeMat = _apemat;
          

        }
        public void print()
        {

            Console.Write("Nombre: ", Nombre);
            Console.Write("Apellido Paterno: ", ApePat);
            Console.Write("Apellido Materno: ", ApeMat);
            Console.Write("Dni: ", Dni);

         }

        }
}
