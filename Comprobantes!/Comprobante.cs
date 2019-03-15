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
        public DateTime Vencimiento1 { get; set; }
        public DateTime Vencimiento2 { get; set; }
        public DateTime Vencimiento3 { get; set; }
        public DateTime FechaPago { get; set; }
        public string Detalle { get; set; }
        public decimal Importe { get; set; }
        public decimal Interes { get; set; }
        public decimal DiasPagar { get; set; }
        public decimal DiasDeIncrementoDeInteres{ get; set; }
        public decimal InteresAumentado { get; set; }
    }
    
}
