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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = Control.CRUD_Producto.MostrarProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            TxtDescripcion.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            TxtMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            TxtCosto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString(); 
            TxtProveedor.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
