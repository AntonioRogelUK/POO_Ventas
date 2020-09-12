using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto();
            producto1.Clave = "001";
            producto1.Descripcion = "Sabritas";
            producto1.ValorUnitario = 15.00M;
            producto1.AplicaIVA = true;
            producto1.TasaIVA = 0.16M;

            Producto producto2 = new Producto();
            producto2.Clave = "002";
            producto2.Descripcion = "Refresco 600ml";
            producto2.ValorUnitario = 16.00M;
            producto2.AplicaIVA = true;
            producto2.TasaIVA = 0.16M;

            Producto producto3 = new Producto();
            producto3.Clave = "Celular";
            producto3.Descripcion = "Celular marca Motorola";
            producto3.ValorUnitario = 2500M;
            producto3.AplicaIVA = true;
            producto3.TasaIVA = 0.16M;

            Venta venta = new Venta();
            venta.AgregarConcepto(5, producto2);
            venta.AgregarConcepto(3, producto1);
            venta.AgregarConcepto(10, producto3);


            Imprimir(venta);

            Console.ReadKey();
        }
        static void Imprimir(Venta venta) 
        {
            Console.WriteLine($"Fecha de la venta {venta.Fecha:dd/MM/yyyy}");
            Console.WriteLine("");
            Console.WriteLine("Cantidad Clave\t\tDescripcion\t\t\tValorUnitario\tImporte\tTasaIVA");
            foreach(VentaConceptos concepto in venta.Conceptos) 
            {
                Console.WriteLine($"{concepto.Cantidad:N2}\t" +
                    $"{concepto.Producto.Clave}\t" +
                    $"{concepto.Producto.Descripcion}\t" +
                    $"{concepto.ValorUnitario:N2}\t" +
                    $"{concepto.Importe:N2}\t" +
                    $"{concepto.Producto.TasaIVA:N2}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Subtotal: {venta.SubTotal:C2}");
            Console.WriteLine($"IVA: {venta.IVA:C2}"); 
            Console.WriteLine($"Total: {venta.Total:C2}");
        }
    }
}
