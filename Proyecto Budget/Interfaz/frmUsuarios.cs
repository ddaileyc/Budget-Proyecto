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

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
            Modelo.Usuario usuarioNuevo = new Modelo.Usuario();
            usuarioNuevo.Nombre = txtNombre.Text;
            usuarioNuevo.Apellido = txtApellidos.Text;
            usuarioNuevo.Cedula = int.Parse(txtCedula.Text);
            usuarioNuevo.Departamento = setDptID(cbDepartamentos.SelectedIndex);
            usuarioNuevo.Rol = setRol(cbRol.SelectedIndex);
            usuarioNuevo.Telefono = int.Parse(txtTelefono.Text);
            usuarioNuevo.Id_sistema = usuarioNuevo.Nombre.Substring(0,1).ToLower() + usuarioNuevo.Apellido.Trim().ToLower();
            usuarioNuevo.Contrasena = usuarioNuevo.Id_sistema;
            try
            {
                usuario.insertarUsuario(usuarioNuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar ususario: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
            Modelo.BudgetEntities budgetContext = new Modelo.BudgetEntities();
            dgvUsuarios.DataSource = usuario.MostrarUsuarios();
            dgvUsuarios.AutoResizeColumns();
        }

        //private void dgvUsuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
        //    txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
        //    txtCedula.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
        //    cbDepartamentos.SelectedValue = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
        //}

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            usuario.iD = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            usuario.eliminarUsuario(usuario.id);
            //Resetear Datagrid
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuario.MostrarUsuarios();
            dgvUsuarios.Refresh();
            dgvUsuarios.AutoResizeColumns();
        }

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

        public int setDptID(int indice)
        {
            switch (indice)
            {
                case 0:
                    return 10;
                case 1:
                    return 20;
                case 2:
                    return 30;
                case 3:
                    return 40;
                case 4:
                    return 50;
                case 5:
                    return 60;
                case 6:
                    return 70;
                case 7:
                    return 80;
                case 8:
                    return 90;
                case 9:
                    return 100;
                default:
                    return 20;
            }
        }

        public byte setRol(int indice)
        {
            switch (indice)
            {
                case 0:
                    return Convert.ToByte(50);
                case 1:
                    return Convert.ToByte(100);
                case 2:
                    return Convert.ToByte(150);
                case 3:
                    return Convert.ToByte(200);
                default:
                    return Convert.ToByte(200);
            }
        }
    }
}
