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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Producto where x.Nombre.Contains(txtProducto.Text) select new { x.Nombre, x.Marca, x.Descripcion, x.Costo };
            dgvProductosCompra.DataSource = qry.ToList();
            dgvProductosCompra.Refresh();
            dgvProductosCompra.AutoResizeColumns();
        }

        private void dgvProductosCompra_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblNombre.Text =  dgvProductosCompra.CurrentRow.Cells[0].Value.ToString();
            lblMarca.Text = dgvProductosCompra.CurrentRow.Cells[1].Value.ToString();
            lblDesc.Text = dgvProductosCompra.CurrentRow.Cells[2].Value.ToString();
            double precio = double.Parse(dgvProductosCompra.CurrentRow.Cells[3].Value.ToString());
            precio *= 1.13;
            precio = Math.Round(precio, 2);
            lblPrecio.Text += precio.ToString();
        }
    }
}
