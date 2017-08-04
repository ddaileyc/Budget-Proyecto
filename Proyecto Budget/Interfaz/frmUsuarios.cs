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

        #region "CRUD"
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
            Modelo.BudgetEntities budgetContext = new Modelo.BudgetEntities();
            MostrarUsuarios();
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
            usuarioNuevo.Id_sistema = usuarioNuevo.Nombre.Substring(0, 1).ToLower() + usuarioNuevo.Apellido.Trim().ToLower();
            usuarioNuevo.Contrasena = usuarioNuevo.Id_sistema;
            try
            {
                usuario.insertarUsuario(usuarioNuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar ususario: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvUsuarios.DataSource = null;
            MostrarUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Control.CRUD_Usuario usuario = new Control.CRUD_Usuario();
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            usuarioModelo.Id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            usuario.eliminarUsuario(usuarioModelo);
            //Resetear Datagrid
            dgvUsuarios.DataSource = null;
            MostrarUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            usuarioModelo.Id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            try
            {
                var original = modelo.Usuario.Find(usuarioModelo.Id);
                if (original != null)
                {
                    original.Nombre = txtNombre.Text;
                    original.Apellido = txtApellidos.Text;
                    original.Cedula = int.Parse(txtCedula.Text);
                    original.Departamento = setDptID(cbDepartamentos.SelectedIndex);
                    original.Rol = setRol(cbRol.SelectedIndex);
                    original.Telefono = int.Parse(txtTelefono.Text);
                    modelo.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Resetear Datagrid
            dgvUsuarios.DataSource = null;
            MostrarUsuarios();
        }
        #endregion 

        #region "Setear comboboxes"
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

        public int setDptIndex(int dpto)
        {
            switch (dpto)
            {
                case 10:
                    return 0;
                case 20:
                    return 1;
                case 3:
                    return 2;
                case 40:
                    return 3;
                case 50:
                    return 4;
                case 60:
                    return 5;
                case 70:
                    return 6;
                case 80:
                    return 7;
                case 90:
                    return 8;
                case 100:
                    return 9;
                default:
                    return 1;
            }
        }

        public int setRol(int indice)
        {
            switch (indice)
            {
                case 0:
                    return 50;
                case 1:
                    return 100;
                case 2:
                    return 150;
                case 3:
                    return 200;
                default:
                    return 200;
            }
        }

        public int setRolIndex(int indice)
        {
            switch (indice)
            {
                case 50:
                    return 0;
                case 100:
                    return 1;
                case 150:
                    return 2;
                case 200:
                    return 3;
                default:
                    return 1;
            }
        }
        #endregion

        public void MostrarUsuarios()
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Usuario select new { x.Id, x.Nombre, x.Apellido, x.Cedula, x.Telefono, x.Departamento, x.Id_sistema, x.Rol };
            dgvUsuarios.DataSource = qry.ToList();
            dgvUsuarios.Refresh();
            dgvUsuarios.AutoResizeColumns();
        }

        private void btnPassReset_Click(object sender, EventArgs e)
        {
            frmPassReset resetearPassword = new frmPassReset(dgvUsuarios.CurrentRow.Cells[6].Value.ToString());
            resetearPassword.Show();
        }
     
        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtCedula.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            cbDepartamentos.SelectedIndex = setDptIndex(int.Parse(dgvUsuarios.CurrentRow.Cells[5].Value.ToString()));
            cbRol.SelectedIndex = setRolIndex(int.Parse(dgvUsuarios.CurrentRow.Cells[7].Value.ToString()));
        }
    }
}
