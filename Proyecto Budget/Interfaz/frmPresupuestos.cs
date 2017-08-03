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
        SqlConnection objConn;
        SqlCommand objCmd;
        string CadenaBD = @"Data Source=db-budget.database.windows.net;Initial Catalog=Budget;Persist Security Info=True;User ID=budget-admin; password=p455w0rD";
        List<Control.CRUD_Presupuesto> lista;
        public frmPresupuestos()
        {
            InitializeComponent();
            cargarPresupuestos();
            cargarDepartamentos();
        }

        public void cargarDepartamentos()
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Departamento select new {x.Id, x.Nombre};
            dgvDepartamentos.DataSource = qry.ToList();
            dgvDepartamentos.Refresh();
            dgvDepartamentos.AutoResizeColumns();
        }

        public void cargarPresupuestos()
        {
            Modelo.BudgetEntities modelo = new Modelo.BudgetEntities();
            var qry = from x in modelo.Presupuesto select new {x.Id, x.Departamento, x.Descripcion, x.Monto, x.Fecha_Expiracion, x.Fecha_Inicio};
            dgvPresupuestos.DataSource = qry.ToList();
            dgvPresupuestos.Refresh();
            dgvPresupuestos.AutoResizeColumns();
        }

        private void dgvDepartamentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbDepartamentos.SelectedIndex = seleccionarDepartamento(int.Parse(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString()));
        }

        private int seleccionarDepartamento (int indice)
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

        private void btnAgregarPresupuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
