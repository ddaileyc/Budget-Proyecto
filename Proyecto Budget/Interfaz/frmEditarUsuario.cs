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
    public partial class frmEditarUsuario : Form
    {
        public string userConstructor;
        public frmEditarUsuario(string user)
        {
            InitializeComponent();
            this.userConstructor = user;
            this.txtUsuario.Text = user;
        }

        private void btnPassReset_Click(object sender, EventArgs e)
        {
            frmPassReset resetearPassword = new frmPassReset(userConstructor);
            resetearPassword.Show();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            usuarioModelo.Id = (from x in modelo.Usuario where x.Id_sistema == txtUsuario.Text select x.Id).FirstOrDefault();
            try
            {
                var original = modelo.Usuario.Find(usuarioModelo.Id);
                if (original != null)
                {
                    original.Nombre = txtNombre.Text;
                    original.Apellido = txtApellidos.Text;
                    original.Cedula = int.Parse(txtCedula.Text);
                    original.Telefono = int.Parse(txtTelefono.Text);
                    modelo.SaveChanges();
                    MessageBox.Show("Se ha editado el usuario correctamente", "Operación realizada satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = original.Nombre;
                    txtNombre.Enabled = false;
                    txtApellidos.Text = original.Apellido;
                    txtApellidos.Enabled = false;
                    txtCedula.Text = original.Cedula.ToString();
                    txtCedula.Enabled = false;
                    original.Telefono = int.Parse(txtTelefono.Text);
                    txtTelefono.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
