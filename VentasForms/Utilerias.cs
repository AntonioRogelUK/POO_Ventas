using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasForms
{
    public static class Utilerias
    {
        public static bool TextBoxDecimal(object sender, KeyPressEventArgs Input) 
        {
			try
			{
				if (sender is TextBox txt) 
				{
					string valor = txt.Text;
					int punto = valor.IndexOf(".");

					if (txt.SelectedText.IndexOf(".") > -1) 
					{
						punto = -1;
					}

					if(Input.KeyChar == Convert.ToChar(".")) 
					{
						if (punto != -1) 
						{
							Input.Handled = true;
						}
					}

					if (
						!Char.IsNumber(Input.KeyChar)
						&& !(Input.KeyChar == (Convert.ToChar(Keys.Delete)))
						&& !(Input.KeyChar == (Convert.ToChar(Keys.Back)))
						&& !(Input.KeyChar == (Convert.ToChar(45)))) 
					{
						Input.Handled = true;
					}
					return Input.Handled;
				}
				else 
				{
					throw new Exception("Solo se puede validar objetos del tipo TextBox");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
        }
		public static void TextBoxDecimalLeave(object sender, string valorPorDefecto = "0.00") 
		{
			try
			{
				if (sender is TextBox txt)
				{
					if (string.IsNullOrEmpty(txt.Text)) 
					{
						txt.Text = valorPorDefecto;
					}

					decimal.TryParse(txt.Text, out decimal datoNumerico);
					txt.Text = datoNumerico.ToString("N2");
				}
				else
				{
					throw new Exception("Solo se puede validar objetos del tipo TextBox");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		//Sobrecarga----------------------------------------------------
		public static void TextBoxDecimalLeaveEnter(object sender, KeyEventArgs Input) 
		{
			try
			{
				if (sender is TextBox txt)
				{
					if (Input.KeyData == Keys.Enter)
					{
						TextBoxDecimalLeave(sender);
					}
				}
				else
				{
					throw new Exception("Solo se puede validar objetos del tipo TextBox");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static void TextBoxDecimalLeaveEnter(object sender, KeyEventArgs Input, Button boton)
		{
			try
			{
				if (sender is TextBox txt)
				{
					if (Input.KeyData == Keys.Enter)
					{
						TextBoxDecimalLeave(sender);
						boton.PerformClick();
					}
				}
				else
				{
					throw new Exception("Solo se puede validar objetos del tipo TextBox");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		//---------------------------------------------------------------
	}
}
