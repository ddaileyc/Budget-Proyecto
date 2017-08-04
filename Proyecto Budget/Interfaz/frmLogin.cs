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
    public partial class frmLogin : Form
    {
        frmPrincipalAdmin principal = new frmPrincipalAdmin();
        frmBudgetUser principalUsuario = new frmBudgetUser();
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Control.CRUD_Usuario validacion = new Control.CRUD_Usuario();
            if (validacion.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                if (setPermisos() != 10)
                {
                    principalUsuario.Show();
                    this.Hide();
                }
                else
                {
                    principal.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor digite un usuario y contraseña válidos", "Usuario o contraseña inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion por completo
            Application.Exit();
        }
        //Metodos esteticos de form
        private void label3_MouseHover(object sender, EventArgs e)
        {
            this.lblSalir.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.lblSalir.ForeColor = Color.DarkBlue;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.lblOlvidoContrasena.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.lblOlvidoContrasena.ForeColor = Color.DarkBlue;
        }

        private int setPermisos()
        {
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            usuarioModelo.Id_sistema = txtUsuario.Text;
            try
            {
                var original = modelo.Usuario.FirstOrDefault(x => x.Id_sistema == usuarioModelo.Id_sistema);
                if (original != null)
                {
                    return original.Rol;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 0;
        }
    }
}
