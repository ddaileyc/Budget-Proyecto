using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // para trabajar con datos de sql
using System.Data.SqlClient; // para poder enviar comando desde visual a sql
using System.Windows.Forms;

namespace Proyecto_Budget.Control
{
    class CRUD_Factura
    {


        public static Conexion.ConexionDB controlDBCompra = new Conexion.ConexionDB();
        public int Id { get; set; }
        public int Id_Compra{ get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }


        public DataTable MostrarFactura()
        {
            DataTable DtCompra = new DataTable("Factura");
            controlDBCompra.MostrarCompra(DtCompra);
            return DtCompra;
        }







    }
}
