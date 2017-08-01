using Proyecto_Budget.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Budget
{
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
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

        private void btnAdmon_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.MdiParent = this;
            reportes.Show();
        }
    }
}
