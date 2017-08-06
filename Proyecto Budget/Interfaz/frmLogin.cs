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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmPrincipalAdmin formAdmin = new frmPrincipalAdmin();
            frmBudgetUser formUsuario = new frmBudgetUser(setPermisos(), setDpto());
            Control.CRUD_Usuario validacion = new Control.CRUD_Usuario();
            if (validacion.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                if (setPermisos() != 10)
                {
                    formUsuario.Show();
                    this.Hide();
                }
                else
                {
                    formAdmin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor digite un usuario y contraseña válidos", "Usuario o contraseña inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region "Metodos esteticos de form"
        private void label3_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion por completo
            Application.Exit();
        }
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
        #endregion

        #region Setear parametros de usuario
        private int setDpto()
        {
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            usuarioModelo.Id_sistema = txtUsuario.Text;
            try
            {
                var original = modelo.Usuario.FirstOrDefault(x => x.Id_sistema == usuarioModelo.Id_sistema);
                if (original != null)
                {
                    return original.Departamento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario no pertenece a ningún departamento: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 0;
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
                MessageBox.Show("Usuario no pertenece a ningún rol: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 0;
        }
        #endregion
    }
}
