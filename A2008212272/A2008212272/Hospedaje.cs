using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    public class Hospedaje : ServicioTuristico {

        public Hospedaje(int _codigo)
        {
            Codigo = _codigo;
 
        }

        public List<TipoHospedaje> _TipoHospedajes;
        public List<CalificacionHospedaje> _CalificacionHospedajes;
        public List<CategoriaHospedaje> _CategoriaHospedajes;
        public List<ServicioHospedaje> _ServicioHospedajes;

        public Hospedaje() {

            _TipoHospedajes = new List<TipoHospedaje>();
            _CalificacionHospedajes = new List<CalificacionHospedaje>();
            _CategoriaHospedajes = new List<CategoriaHospedaje>();
            _ServicioHospedajes = new List<ServicioHospedaje>();
        }

        public void print()
        {
            Console.Write("Codigo de Servicio:", Codigo);
            Console.Write("Tipo de Hospedaje:", _TipoHospedajes);
            Console.Write("Calificacion de Hospedaje:", _CalificacionHospedajes);
            Console.Write("Categoria de Hospedaje:", _CategoriaHospedajes);
            Console.Write("Servicio de Hospedaje:", _ServicioHospedajes);
        }

    }
}
