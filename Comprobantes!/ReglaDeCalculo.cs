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

            if (dias >= comprobante.DiasPagar)
            {
              
                recargo = ((comprobante.InteresAumentado * comprobante.Importe) / 100) + comprobante.Importe;
            }
           

            return recargo;
        }
		                   
    }
}
