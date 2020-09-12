using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasForms
{
    public partial class frmVentas : Form
    {
        Venta venta = new Venta();
        public frmVentas()
        {
            InitializeComponent();

            txtProductoValorUnitario.TextAlign = HorizontalAlignment.Right;
            txtProductoTasaIVA.TextAlign = HorizontalAlignment.Right;
            txtConceptoCantidad.TextAlign = HorizontalAlignment.Right;
            txtVentaSubtotal.TextAlign = HorizontalAlignment.Right;
            txtVentaIVA.TextAlign = HorizontalAlignment.Right;
            txtVentaTotal.TextAlign = HorizontalAlignment.Right;

            txtVentaSubtotal.ReadOnly = true;
            txtVentaIVA.ReadOnly = true;
            txtVentaTotal.ReadOnly = true;

            txtVentaSubtotal.Text = "0.00";
            txtVentaIVA.Text = "0.00";
            txtVentaTotal.Text = "0.00";

            txtProductoTasaIVA.KeyPress += Txt_KeyPress;
            txtProductoValorUnitario.KeyPress += Txt_KeyPress;
            txtConceptoCantidad.KeyPress += Txt_KeyPress;

            txtProductoTasaIVA.Leave += Txt_Leave;
            txtProductoValorUnitario.Leave += Txt_Leave;
            txtConceptoCantidad.Leave += Txt_Leave;

            txtProductoTasaIVA.KeyDown += Txt_KeyDown;
            txtProductoValorUnitario.KeyDown += Txt_KeyDown;
            txtConceptoCantidad.KeyDown += TxtConceptoCantidad_KeyDown;

            InicializarProducto();
        }

        private void TxtConceptoCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.TextBoxDecimalLeaveEnter(sender, e, btnConceptosAgregar);
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.TextBoxDecimalLeaveEnter(sender, e);
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            Utilerias.TextBoxDecimalLeave(sender);
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilerias.TextBoxDecimal(sender, e);
        }

        private void btnConceptosAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void InicializarProducto() 
        {
            txtProductoClave.Text = string.Empty;
            txtProductoDescripcion.Text = string.Empty;
            txtProductoValorUnitario.Text = "0.00";
            txtProductoTasaIVA.Text = "0.16";
            txtConceptoCantidad.Text = "0.00";
            chkProductoAplicaIVA.Checked = true;
        }
        private void AgregarProducto() 
        {
            try
            {
                Producto producto = ObtenerProducto();

                decimal.TryParse(txtConceptoCantidad.Text, out decimal cantidad);

                if (cantidad <= 0) 
                {
                    throw new Exception("La cantidad de producto(s) debe ser mayor que cero");
                }

                venta.AgregarConcepto(cantidad, producto);
                InicializarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarDatos() 
        {
            try
            {
                dtgConceptos.Rows.Clear();
                foreach(VentaConceptos conceptos in venta.Conceptos) 
                {
                    dtgConceptos.Rows.Add(conceptos.Cantidad,
                        conceptos.Producto.Clave,
                        conceptos.Producto.Descripcion,
                        conceptos.ValorUnitario,
                        conceptos.Importe);
                }

                txtVentaSubtotal.Text = venta.SubTotal.ToString("N2");
                txtVentaIVA.Text = venta.IVA.ToString("N2");
                txtVentaTotal.Text = venta.Total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Producto ObtenerProducto() 
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductoClave.Text)) 
                {
                    throw new Exception("Se debe especificar la clave del producto");
                }

                if (string.IsNullOrEmpty(txtProductoDescripcion.Text))
                {
                    throw new Exception("Se debe especificar la descripción del producto");
                }

                decimal.TryParse(txtProductoValorUnitario.Text, out decimal valorUnitario);
                decimal.TryParse(txtProductoTasaIVA.Text, out decimal tasaIVA);

                if (valorUnitario < 0) 
                {
                    throw new Exception("El valor unitario del producto no puede ser menor que cero");
                }

                if (chkProductoAplicaIVA.Checked && tasaIVA <= 0) 
                {
                    throw new Exception("La tasa de IVA debe ser mayor que cero");
                }

                Producto producto = new Producto();
                producto.Clave = txtProductoClave.Text;
                producto.Descripcion = txtProductoDescripcion.Text;
                producto.AplicaIVA = chkProductoAplicaIVA.Checked;
                producto.TasaIVA = tasaIVA;
                producto.ValorUnitario = valorUnitario;

                return producto;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void InicializarForm() 
        {
            InicializarProducto();
            MostrarDatos();
            txtProductoClave.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciarVenta_Click(object sender, EventArgs e)
        {
            venta = new Venta();
            InicializarForm();
        }

        private void chkProductoAplicaIVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProductoAplicaIVA.Checked)
            {
                txtProductoTasaIVA.ReadOnly = false;
                txtProductoTasaIVA.Text = "0.16";
            }
            else 
            {
                txtProductoTasaIVA.ReadOnly = true;
                txtProductoTasaIVA.Text = "0.00";
            }
        }
    }
}

