using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    public class Alimentacion : ServicioTuristico {

        public Alimentacion(int _codigo)
        {
            Codigo = _codigo;
        }

        public List<CategoriaAlimentacion> _CategoriaAlimentaciones;

        public Alimentacion()
        {
            _CategoriaAlimentaciones = new List<CategoriaAlimentacion>();
        }


        public void print()
        {
            Console.Write("Codigo de Servicio:", Codigo);
            Console.Write("Categoria de Alimentacion:", _CategoriaAlimentaciones);



        }
    }
}
