using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Producto
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool AplicaIVA { get; set; }
        public decimal TasaIVA { get; set; }
    }
}