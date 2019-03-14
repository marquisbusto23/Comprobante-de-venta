using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes_
{
    public class ReglaDeCalculo
    {
        public decimal CalcularRecargo(Comprobante comprobante, int dias)
        {
            decimal recargo = 0;
            if (dias <= 10)
            {
                recargo = comprobante.Importe;
                
            }
            else if (dias <= 20)
            {
                recargo = comprobante.Importe + (comprobante.Importe * Convert.ToDecimal(0.10));
               
            }
            else if (dias <= 30)
            {
                recargo = comprobante.Importe + (comprobante.Importe * Convert.ToDecimal(0.20));
                
            }
            else if (dias <= 40)
            {
                recargo = comprobante.Importe + (comprobante.Importe * Convert.ToDecimal(0.30));
                
            }
            else if (dias <= 50)
            {
                recargo = comprobante.Importe + (comprobante.Importe * Convert.ToDecimal(0.40));
                
            }


            return recargo;
        }
	

	    
         
       
    }
}
