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
    class CRUD_Compra
    {

        public static Conexion.ConexionDB controlDBCompra = new Conexion.ConexionDB();
        public int id { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public int Estado { get; set; }


        public DataTable MostrarCompra()
        {
            DataTable DtCompra= new DataTable("Compra");
            controlDBCompra.MostrarCompra(DtCompra);
            return DtCompra;
        }


    }
}
