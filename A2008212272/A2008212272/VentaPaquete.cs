using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
 public class VentaPaquete {

        public int IdVenta { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }

        public List<ComprobantePago> _comprobantePago;
        public List<MedioPago> _medioPago;
        public List<Paquete> _paquete;
        public List<Empleado> _empleado;
        public List<Cliente> _cliente;
        private MedioPago efectivo;
        private TipoComprobante boleta;
        private MedioPago efectivo1;

        public VentaPaquete() {

            _comprobantePago = new List<ComprobantePago>();
            _medioPago = new List<MedioPago>();
            _paquete = new List<Paquete>();
            _empleado = new List<Empleado>();
            _cliente = new List<Cliente>();


        }



        public VentaPaquete(TipoComprobante boleta, MedioPago efectivo)
        {
            this.boleta = boleta;
            this.efectivo = efectivo;

              }
        }
}
