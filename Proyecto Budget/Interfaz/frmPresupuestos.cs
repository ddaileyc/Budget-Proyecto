using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Budget.Interfaz
{
    public partial class frmPresupuestos : Form
    {
        public frmPresupuestos()
        {
            InitializeComponent();
            cargarPresupuestos();
            cargarDepartamentos();
        }

        public void cargarDepartamentos()
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Departamento select new { x.Id, x.Nombre };
            dgvDepartamentos.DataSource = qry.ToList();
            dgvDepartamentos.Refresh();
            dgvDepartamentos.AutoResizeColumns();
        }

        public void cargarPresupuestos()
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Presupuesto select new { x.Id, x.Departamento, x.Descripcion, x.Monto, x.Fecha_Expiracion, x.Fecha_Inicio };
            dgvPresupuestos.DataSource = qry.ToList();
            dgvPresupuestos.Refresh();
            dgvPresupuestos.AutoResizeColumns();
        }

        private void dgvDepartamentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbDepartamentos.SelectedIndex = seleccionarDepartamento(int.Parse(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString()));
        }

        private int seleccionarDepartamento(int indice)
        {
            switch (indice)
            {
                case 10:
                    return 0;
                case 20:
                    return 1;
                case 30:
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

        public int setDptID(string nombreDpto)
        {
            switch (nombreDpto)
            {
                case "Credito":
                    return 0;
                case "Tecnologia":
                    return 1;
                case "Contabilidad":
                    return 2;
                case "Ventas":
                    return 3;
                case "Gerencia":
                    return 4;
                case "Tesoreria":
                    return 5;
                case "Cobros":
                    return 6;
                case "Recursos Humanos":
                    return 7;
                case "Mercadeo":
                    return 8;
                case "Capacitacion":
                    return 9;
                default:
                    return 1;
            }
        }

        private void btnAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            Control.CRUD_Presupuesto presupuesto = new Control.CRUD_Presupuesto();
            Modelo.Presupuesto presupuestoNuevo = new Modelo.Presupuesto();
            presupuestoNuevo.Descripcion = txtDesc.Text;
            presupuestoNuevo.Departamento = setDptID(cbDepartamentos.SelectedIndex);
            presupuestoNuevo.Monto = decimal.Parse(txtMonto.Text);
            presupuestoNuevo.Fecha_Inicio = dtInicio.Value.Date;
            presupuestoNuevo.Fecha_Expiracion = dtFin.Value.Date;
            try
            {
                presupuesto.insertarPresupuesto(presupuestoNuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarPresupuestos();
        }

        private void btnEditarPresupuesto_Click(object sender, EventArgs e)
        {
            Modelo.Presupuesto presupuestoModelo = new Modelo.Presupuesto();
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            presupuestoModelo.Id = int.Parse(dgvPresupuestos.CurrentRow.Cells[0].Value.ToString());
            try
            {
                var original = modelo.Presupuesto.Find(presupuestoModelo.Id);
                if (original != null)
                {
                    original.Descripcion = txtDesc.Text;
                    original.Departamento = setDptID(cbDepartamentos.SelectedIndex);
                    original.Monto = decimal.Parse(txtMonto.Text);
                    original.Fecha_Inicio = dtInicio.Value.Date;
                    original.Fecha_Expiracion = dtFin.Value.Date;
                    modelo.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Resetear Datagrid
            cargarPresupuestos();
        }

        private void btnEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            Control.CRUD_Presupuesto presupuesto = new Control.CRUD_Presupuesto();
            Modelo.Presupuesto presupuestoModelo = new Modelo.Presupuesto();
            presupuestoModelo.Id = int.Parse(dgvPresupuestos.CurrentRow.Cells[0].Value.ToString());
            try
            {
                presupuesto.eliminarPresupuesto(presupuestoModelo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar presupuesto: " + ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Resetear Datagrid
            cargarPresupuestos();
        }

        private void dgvPresupuestos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbDepartamentos.SelectedIndex = setDptID(dgvPresupuestos.CurrentRow.Cells[1].Value.ToString());
            txtDesc.Text = dgvPresupuestos.CurrentRow.Cells[2].Value.ToString();
            txtMonto.Text = dgvPresupuestos.CurrentRow.Cells[3].Value.ToString();
            dtInicio.Value = Convert.ToDateTime(dgvPresupuestos.CurrentRow.Cells[4].Value);
            dtFin.Value = Convert.ToDateTime(dgvPresupuestos.CurrentRow.Cells[5].Value);
        }
    }
}
