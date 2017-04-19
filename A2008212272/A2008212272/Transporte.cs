using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    public class Transporte : ServicioTuristico {
        public Transporte(int _codigo)
        {
            Codigo = _codigo;

        }
        public List<TipoTransporte> _TipoTransportes;
        public List<CategoriaTransporte> _CategoriaTransportes;

        public Transporte()
        {

            _TipoTransportes = new List<TipoTransporte>();
            _CategoriaTransportes = new List<CategoriaTransporte>();
        }

        public void print()
        {
            Console.Write("Codigo de Servicio:", Codigo);
            Console.Write("Tipo de Transporte:", _TipoTransportes);
            Console.Write("Categoria de Transporte:", _CategoriaTransportes);


        }

    }
}
