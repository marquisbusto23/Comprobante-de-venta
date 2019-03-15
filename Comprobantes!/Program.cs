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
            Console.WriteLine("Tipo de Factura:"+comprobantes.TipoDeComprobante);

            Console.WriteLine("Ingrese Datos del cliente");
            comprobantes.DatosDeCliente = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Datos ingresados:"+comprobantes.DatosDeCliente);

            Console.WriteLine("Ingrese Detalles:");
            comprobantes.Detalle = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Detalles:"+comprobantes.Detalle);

            Console.WriteLine("Ingresar fecha de EMISION(ingresar dd mm aaaa)");
            comprobantes.FechaEmision = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("fecha ingresada: "+comprobantes.FechaEmision);

            
            //comprobantes.Vencimiento1 = comprobantes.FechaEmision.AddDays(15);
            //Console.WriteLine("1° VENCIMIENTO: " + comprobantes.Vencimiento1);

            
            //comprobantes.Vencimiento2 = comprobantes.FechaEmision.AddDays(30);
            //Console.WriteLine("2° VENCIMIENTO: " + comprobantes.Vencimiento2);

            
            //comprobantes.Vencimiento3 = comprobantes.FechaEmision.AddDays(60);
            //Console.WriteLine("3° VENCIMIENTO: " + comprobantes.Vencimiento3);

            Console.WriteLine("Ingresar fecha de PAGO(ingresar dd mm aaaa)");
            comprobantes.FechaPago = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("fecha ingresada: " + comprobantes.FechaPago);

                      
            int dias = (comprobantes.FechaPago - comprobantes.FechaEmision).Days;
            Console.WriteLine(dias);

            Console.WriteLine("Ingrese monto:");
            comprobantes.Importe = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Monto ingresado:"+comprobantes.Importe);

            Console.WriteLine("Ingrese cada cuantos dias se aumenta el interes:");
            comprobantes.DiasPagar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dias pasados:" + comprobantes.DiasPagar);

            Console.WriteLine("Ingrese interes:");
            comprobantes.Interes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Interes ingresado:" + comprobantes.Interes);

            comprobantes.DiasDeIncrementoDeInteres = dias / comprobantes.DiasPagar;
            comprobantes.InteresAumentado = comprobantes.DiasDeIncrementoDeInteres * comprobantes.Interes;

            var recargoServicio = new ReglaDeCalculo();
            var recargoCobrar = recargoServicio.CalcularRecargo(comprobantes, dias); 

            Console.WriteLine("Valor de la Factura con interes aplicado:" + recargoCobrar);

        }     
        
    }
}
