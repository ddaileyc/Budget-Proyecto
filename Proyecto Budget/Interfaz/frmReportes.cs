using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop;




namespace Proyecto_Budget.Interfaz
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void BtnReporteCompra_Click(object sender, EventArgs e)
        {
            Control.CRUD_Compra Compra = new Control.CRUD_Compra();
            dataGridView1.DataSource = Compra.MostrarCompra();
            dataGridView1.AutoResizeColumns();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {

            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();

                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //////////////////// para agregar el encabezado revisar////////7
                //hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //for (int i = 0; i < dataGridView1.ColumnCount; i++)
                //{
                //    hoja_trabajo.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                //}



                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }

        }//fin del boton expotarr

        private void BtnReporteFactura_Click(object sender, EventArgs e)
        {
            Control.CRUD_Factura Compra = new Control.CRUD_Factura();
            dataGridView1.DataSource = Compra.MostrarFactura();
            dataGridView1.AutoResizeColumns();
        }
    }
}

