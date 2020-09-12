using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class VentaConceptos
    {
        public VentaConceptos()
        {
            Producto = new Producto();
        }

        public decimal Cantidad { get; set; }
        public Producto Producto { get; set; }
        public decimal ValorUnitario { 
            get 
            {
                return Producto.ValorUnitario;
            } 
        }
        public decimal Importe { 
            get 
            {
                return Cantidad * ValorUnitario;
            } 
        }
        public decimal ImporteIVA { 
            get 
            {
                return (Producto.AplicaIVA) ? Importe * Producto.TasaIVA : 0.00M;
            }
        }
    }
}