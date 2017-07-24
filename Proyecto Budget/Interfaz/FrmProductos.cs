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
            Control.CRUD_Producto producto = new Control.CRUD_Producto();
            dgvProductos.DataSource = producto.MostrarProductos();
            dgvProductos.AutoResizeColumns();
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            TxtDescripcion.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            TxtMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            TxtCosto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            TxtProveedor.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            Control.CRUD_Producto producto = new Control.CRUD_Producto();
            producto.nombre = TxtNombre.Text;
            producto.desc = TxtDescripcion.Text;
            producto.marca = TxtMarca.Text;
            producto.costo = double.Parse(TxtCosto.Text);
            producto.proveedor = int.Parse(TxtProveedor.Text);
            producto.insertarProducto(producto);
            //Resetear Datagrid
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = producto.MostrarProductos();
            dgvProductos.Refresh();
            dgvProductos.AutoResizeColumns();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Control.CRUD_Producto producto = new Control.CRUD_Producto();
            producto.id = int.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());
            producto.eliminarProducto(producto.id);
            //Resetear Datagrid
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = producto.MostrarProductos();
            dgvProductos.Refresh();
            dgvProductos.AutoResizeColumns();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            Control.CRUD_Producto producto = new Control.CRUD_Producto();
            producto.nombre = TxtNombre.Text;
            producto.desc = TxtDescripcion.Text;
            producto.marca = TxtMarca.Text;
            producto.costo = double.Parse(TxtCosto.Text);
            producto.proveedor = int.Parse(TxtProveedor.Text);
            producto.id = int.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());
            producto.modificarProducto(producto);
            //Resetear Datagrid
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = producto.MostrarProductos();
            dgvProductos.Refresh();
            dgvProductos.AutoResizeColumns();
        }
    }
}
