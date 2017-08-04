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
    public partial class frmPassReset : Form
    {
        public frmPassReset()
        {
            InitializeComponent();
        }

        public frmPassReset(string userID)
        {
            InitializeComponent();
            this.Text += userID;
            txtUsuario.Text = this.Text.Split(' ')[2];
            txtUsuario.Enabled = false;
        }

        private void btnPassReset_Click(object sender, EventArgs e)
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            Modelo.Usuario usuarioModelo = new Modelo.Usuario();
            usuarioModelo.Id_sistema = txtUsuario.Text;
            try
            {
                var original = modelo.Usuario.Where(x => x.Id_sistema == usuarioModelo.Id_sistema);
                if (original != null && txtPass.Text == txtPassConfirm.Text)
                {
                    original.FirstOrDefault().Contrasena = txtPass.Text;
                    modelo.SaveChanges();
                    MessageBox.Show("Se ha restaurado la contraseña del usuario " + txtUsuario.Text + " satisfactoriamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar contraseña: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
