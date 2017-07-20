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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Codigo de prueba para mostrar el flow, despues hay que mostrar el form de acuerdo con el rol del usuario
            if(txtUsuario.Text.ToString() == "" || txtPassword.Text.ToString() == "")
            {
                string mensajeAlerta = "Por favor digite un usuario y contrasena validos";
                string tituloAlerta = "Usuario o contrasena invalidos";
                MessageBox.Show(mensajeAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {
                principal.Show();
                this.Hide();
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
    }
}
