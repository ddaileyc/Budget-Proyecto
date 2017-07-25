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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        //private void frmUsuarios_Load(object sender, EventArgs e)
        //{
        //    Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
        //    dgvUsuarios.DataSource = usuario.MostrarUsuarios();
        //    cbDepartamentos.DataSource = cargarDepartamentos();
        //    dgvUsuarios.AutoResizeColumns();
        //}

        //private void dgvUsuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
        //    txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
        //    txtCedula.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
        //    cbDepartamentos.SelectedValue = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
        //}

        //private void btnAgregarUsuario_Click(object sender, EventArgs e)
        //{
        //    Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
        //    usuario.nombre = txtNombre.Text;
        //    usuario.cedula = int.Parse(txtCedula.Text);
        //    usuario.direccion = txtDireccion.Text;
        //    usuario.tel = int.Parse(txtTelefono.Text);
        //    usuario.insertarUsuario(usuario);
        //    //Resetear Datagrid
        //    dgvUsuarios.DataSource = null;
        //    dgvUsuarios.DataSource = usuario.MostrarUsuarios();
        //    dgvUsuarios.Refresh();
        //    dgvUsuarios.AutoResizeColumns();
        //}

        //private void btnEliminarUsuario_Click(object sender, EventArgs e)
        //{
        //    Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
        //    usuario.id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
        //    usuario.eliminarUsuario(usuario.id);
        //    //Resetear Datagrid
        //    dgvUsuarios.DataSource = null;
        //    dgvUsuarios.DataSource = usuario.MostrarUsuarios();
        //    dgvUsuarios.Refresh();
        //    dgvUsuarios.AutoResizeColumns();
        //}

        //private void btnEditarUsuario_Click(object sender, EventArgs e)
        //{
        //    Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
        //    usuario.nombre = txtNombre.Text;
        //    usuario.cedula = int.Parse(txtCedula.Text);
        //    usuario.direccion = txtDireccion.Text;
        //    usuario.telefono = int.Parse(txtTelefono.Text);
        //    usuario.id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
        //    usuario.modificarUsuario(usuario);
        //    //Resetear Datagrid
        //    dgvUsuarios.DataSource = null;
        //    dgvUsuarios.DataSource = usuario.MostrarUsuarios();
        //    dgvUsuarios.Refresh();
        //    dgvUsuarios.AutoResizeColumns();
        //}
    }
}
