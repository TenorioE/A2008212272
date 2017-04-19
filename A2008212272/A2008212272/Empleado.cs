using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
  public class Empleado : Persona {
   
        public int Sueldo { get; set; }
        public Empleado(string _nombre, string _apepat, string _apemat, int _dni, int _sueldo) {

            Nombre = _nombre;
            ApePat = _apepat;
            ApeMat = _apemat;
            Dni = _dni;
            Sueldo = _sueldo;
            
        }


        public void print()
        {

            Console.Write("Nombre: ", Nombre);
            Console.Write("Apellido Paterno: ", ApePat);
            Console.Write("Apellido Materno: ", ApeMat);
            Console.Write("Dni: ", Dni);
            Console.Write("Sueldo: ", Sueldo);

            }

        }
}
