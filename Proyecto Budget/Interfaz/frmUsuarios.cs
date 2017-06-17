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









        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Control.User_controller control = new Control.User_controller();
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            Control.User usuario = new Control.User();
            string res;
            usuario.id = Convert.ToInt16(txtid.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Departamento = cboDepartamentos.SelectedIndex;
            usuario.tipo = cboRol.SelectedIndex;
            res = control.AddUser(usuario);

            MessageBox.Show(res);

        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = control.SearchUser(txtid.Text);

            dgvUsuarios.DataSource = dt;

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Control.User usuario = new Control.User();
            string res;
            usuario.id = Convert.ToInt16(txtid.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Departamento = cboDepartamentos.SelectedIndex;
            usuario.tipo = cboRol.SelectedIndex;
            res = control.AddUser(usuario);

            MessageBox.Show(res);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string res;

            res = control.DisposeUser(txtid.Text);
        }
    }
}
