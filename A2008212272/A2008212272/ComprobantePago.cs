using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    public class ComprobantePago
    {

        public int Codigo;

        public ComprobantePago(int _codigo)
        {
            Codigo = _codigo;

        }
        public List<TipoComprobante> _TipoComprobantes;



        public ComprobantePago()
        {

            _TipoComprobantes = new List<TipoComprobante>();

        }
        public void print()
        {
            Console.Write("Codigo de Comprobante: ", Codigo);
            Console.Write("Tipo de Comprobante: ", _TipoComprobantes);

        }
    }
}
