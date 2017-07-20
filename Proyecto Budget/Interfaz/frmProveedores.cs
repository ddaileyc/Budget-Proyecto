using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Budget.Interfaz
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.dgvProveedor.DataSource = Control.CRUD_Proveedor.MostrarProveedores();

        }

        private void dgvProveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
