using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Budget.Interfaz
{
    public partial class frmBudgetUser : Form
    {
        public frmBudgetUser(int rol, int dpto)
        {
            InitializeComponent();
            //Carga de web service del BBCR
            string fecha = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos ws = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            DataSet tipoDeCambioCompra = ws.ObtenerIndicadoresEconomicos("317", fecha, fecha, "Donald Dailey", "N");
            DataSet tipoDeCambioVenta = ws.ObtenerIndicadoresEconomicos("318", fecha, fecha, "Donald Dailey", "N");
            double valorCompra = double.Parse(tipoDeCambioCompra.Tables[0].Rows[0].ItemArray[2].ToString());
            Math.Round(valorCompra, 2);
            double valorVenta = double.Parse(tipoDeCambioVenta.Tables[0].Rows[0].ItemArray[2].ToString());
            Math.Round(valorVenta, 2);
            lblCompra.Text += valorCompra.ToString();
            lblVenta.Text += valorVenta.ToString();
            gbTipoCambio.Text += " al " + Convert.ToDateTime(tipoDeCambioCompra.Tables[0].Rows[0].ItemArray[1].ToString()).ToShortDateString();
            //Control de controles a desplegar por rol de usuario
            //Dependiente
            if (rol == 40)
            {
                btnConta.Hide();
                btnPresup.Hide();
                btnReportes.Hide();
                if (dpto == 60)
                {
                    btnPresup.Show();
                }
                if (dpto == 30)
                {
                    btnConta.Show();
                }
            }
            //Jefe
            if (rol != 40)
            {
                btnConta.Hide();
                btnPresup.Hide();
                if (dpto == 60)
                {
                    btnPresup.Show();
                }
                if (dpto == 30)
                {
                    btnConta.Show();
                    //frmAprobarCompras.Show();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            DialogResult confirmarSalida = MessageBox.Show("¿Está seguro de que quiere cerrar la sesión?", "Salir del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (confirmarSalida == DialogResult.OK)
            {
                login.Show();
                this.Close();
            }
            else if (confirmarSalida == DialogResult.Cancel)
            {
                login.Close();
            }
        }
    }
}
