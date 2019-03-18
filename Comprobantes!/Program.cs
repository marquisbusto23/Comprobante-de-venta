using System;

namespace Comprobantes_
{
    class Program
    {
        static void Main(string[] args)
        {
            var comprobantes = new Comprobante();

            Console.WriteLine("Ingresar tipo de factura:");
            comprobantes.TipoDeComprobante = Convert.ToString(Console.ReadLine());
            
            
            Console.WriteLine("Ingrese Datos del cliente");
            comprobantes.DatosDeCliente = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine("Ingrese Detalles:");
            comprobantes.Detalle = Convert.ToString(Console.ReadLine());
            Console.Clear();
            

            Console.WriteLine("Ingresar fecha de EMISION de factura (formato dd mm aaaa)");
            comprobantes.FechaEmision = Convert.ToDateTime(Console.ReadLine());
            

            Console.WriteLine("Ingresar fecha de PAGO de factura (formato dd mm aaaa)");
            comprobantes.FechaPago = Convert.ToDateTime(Console.ReadLine());
            

            int dias = (comprobantes.FechaPago - comprobantes.FechaEmision).Days;
            

            Console.WriteLine("Ingrese Valor de la Factura:");
            comprobantes.Importe = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Ingrese cada cuantos dias debe aumentar el interes:");
            comprobantes.DiasPagar = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Ingrese interes:");
            comprobantes.Interes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
           
            comprobantes.DiasDeIncrementoDeInteres = (int)dias / (int)comprobantes.DiasPagar;
            comprobantes.InteresAumentado = comprobantes.DiasDeIncrementoDeInteres * comprobantes.Interes;

            var recargoServicio = new ReglaDeCalculo();
            var recargoCobrar = recargoServicio.CalcularRecargo(comprobantes, dias);

            Console.WriteLine("Tipo de Factura:" + comprobantes.TipoDeComprobante);
            Console.WriteLine("Datos del Cliente:" + comprobantes.DatosDeCliente);
            Console.WriteLine("Detalles de la Factura:" + comprobantes.Detalle);
            Console.WriteLine("fecha de Emision: " + comprobantes.FechaEmision);           
            Console.WriteLine("fecha de Pago: " + comprobantes.FechaPago);           
            Console.WriteLine("Valor de Factura:" + comprobantes.Importe);
            Console.WriteLine("Cada " + comprobantes.DiasPagar + " dias aumenta un " + comprobantes.Interes+ "%");
            Console.WriteLine("Dias pasados:" + dias);
            Console.WriteLine("Valor de la Factura con interes aplicado:" + recargoCobrar);


        }     
        
    }
}
