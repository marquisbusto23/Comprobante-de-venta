using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes_
{
    public class Comprobante
    {
        public string TipoDeComprobante { get; set; }
        public string DatosDeCliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public string Detalle { get; set; }
        public decimal Importe { get; set; }

    }
    
}
