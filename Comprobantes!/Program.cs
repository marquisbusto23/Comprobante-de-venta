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

            Console.WriteLine("Ingresar fecha de PAGO(ingresar dd mm aaaa)");
            comprobantes.FechaPago = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("fecha ingresada: " + comprobantes.FechaPago);

            Console.WriteLine("Ingresar fecha de VENCIMIENTO(ingresar dd mm aaaa)");
            comprobantes.FechaVencimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("fecha ingresada: "+comprobantes.FechaVencimiento);


           
            int dias = (comprobantes.FechaPago - comprobantes.FechaVencimiento).Days;
            Console.WriteLine(dias);

            Console.WriteLine("Ingrese monto:");
            comprobantes.Importe = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Monto ingresado:"+comprobantes.Importe);
           
            Console.WriteLine();


            var recargoServicio = new ReglaDeCalculo();
            var recargoCobrar = recargoServicio.CalcularRecargo(comprobantes, dias); //Intanciar la clase


            Console.WriteLine("Monto con interes aplicado:" + recargoCobrar);



        }     
        
    }
}
