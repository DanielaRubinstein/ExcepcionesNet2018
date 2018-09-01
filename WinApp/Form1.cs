using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int tavella;
            //throw new MaxiException("Exception personalizda");
            try
            {
                MessageBox.Show(gordillo().ToString());
                //mas lineas
                //mas lineas
                tavella = int.Parse("A");
                //y mas...
                //y mas y mas

            }
            catch (Exception pablito)
            {
                MessageBox.Show(pablito.Message);
                //MessageBox.Show(pablito.Message);
            }
            finally
            {

            }
        }


        private int gordillo()
        {
            try
            {
                //int resultado;
                return  Convert.ToInt32(txtNumeroUno.Text) / int.Parse(txtNumeroDos.Text);
                //(int) casteo explícito
                //MessageBox.Show(resultado.ToString());
            }
            catch(OverflowException)
            {
                throw new OverflowException("Número muy grande");
            }
            catch(FormatException)
            {
                throw new FormatException("Sólo números, por favor, gracias, de nada.");
            }
            catch (Exception ex)
            {
                //throw;
                throw new Exception("Probá más tarde, gracias. Hasta luego. Vuelvas prontos.");
                //throw pepito;
                //MessageBox.Show("Pasa por catch");
            }
            finally
            {
                //Bloque de código que se ejecuta siempre.
                //MessageBox.Show("Pasa siempre por amici");
            }
        }
    }
}
