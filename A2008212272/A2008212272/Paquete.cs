using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    public class Paquete {

        public int IdPaquete { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public List<ServicioTuristico> _ServicioTuristicos { get; set; }

        public Paquete()
        {

            _ServicioTuristicos = new List<ServicioTuristico>();

        }
    }
}
