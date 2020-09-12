using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Venta
    {
        public DateTime Fecha { get { return DateTime.Now; } }
        public List<VentaConceptos> Conceptos { get; set; }
        public decimal SubTotal { get { return CalcularSubTotal(); } }
        public decimal IVA { get { return CalcularIVA(); } }
        public decimal Total { get { return SubTotal + IVA; } }

        private decimal CalcularSubTotal() 
        {
            decimal subTotal = 0.00M;

            foreach(VentaConceptos concepto in Conceptos) 
            {
                subTotal += concepto.Importe;
            }

            return subTotal;
        }

        private decimal CalcularIVA()
        {
            decimal iva = 0.00M;

            foreach (VentaConceptos concepto in Conceptos)
            {
                iva += concepto.ImporteIVA;
            }

            return iva;
        }
    }
}
