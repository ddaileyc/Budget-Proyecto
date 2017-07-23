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
            Control.CRUD_Proveedor proveedor = new Control.CRUD_Proveedor();
            dgvProveedor.DataSource = proveedor.MostrarProveedores();

        }

        private void dgvProveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Control.CRUD_Proveedor proveedor = new Control.CRUD_Proveedor();
            proveedor.nombre = txtNombre.Text;
            proveedor.cedula = int.Parse(txtCedula.Text);
            proveedor.direccion = txtDireccion.Text;
            proveedor.telefono = int.Parse(txtTelefono.Text);
            proveedor.insertarProveedor(proveedor);
            proveedor.MostrarProveedores();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            Control.CRUD_Proveedor proveedor = new Control.CRUD_Proveedor();
            proveedor.id = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
            proveedor.eliminarProveedor(proveedor.id);
            proveedor.MostrarProveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            Control.CRUD_Proveedor proveedor = new Control.CRUD_Proveedor();
            proveedor.nombre = txtNombre.Text;
            proveedor.cedula = int.Parse(txtCedula.Text);
            proveedor.direccion = txtDireccion.Text;
            proveedor.telefono = int.Parse(txtTelefono.Text);
            proveedor.id = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
            proveedor.modificarProveedor(proveedor);
            proveedor.MostrarProveedores();
        }
    }

}
