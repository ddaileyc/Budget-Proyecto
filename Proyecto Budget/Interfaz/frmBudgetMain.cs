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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Hide();
        }

        private void btnAdmon_Click(object sender, EventArgs e)
        {
            string opcion = "";
            opcion = cbAdmon.Text.ToString();
            //Este switch toma el string opcion que ve el combobox cbAdmon
            //Con base en la selecion del usuario, se mostrara la ventana de administracion pertinente
            //ES NECESARIO QUE EL FORM SE LLAME IGUAL PARA QUE EL CODIGO FUNCIONE
            switch (opcion)
            {
                case "Proveedores":
                    frmProveedores proveedores = new frmProveedores();
                    proveedores.MdiParent = this;
                    proveedores.Dock = DockStyle.Left;
                    proveedores.Show();
                    break;
                //case "Productos":
                //    frmProductos productos = new frmProductos();
                //    productos.MdiParent = this;
                //    productos.Show();
                //    break;
                //case "Servicios":
                //    frmServicios servicios = new frmServicios();
                //    servicios.MdiParent = this;
                //    servicios.Show();
                //    break;
                //case "Usuarios":
                //    frmUsuarios usuarios = new frmUsuarios();
                //    usuarios.MdiParent = this;
                //    usuarios.Show();
                //    break;
                //case "Presupuestos":
                //    frmPresupuestos presupuestos = new frmPresupuestos();
                //    presupuestos.MdiParent = this;
                //    presupuestos.Show();
                //    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
