using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // para trabajar con datos de sql
using System.Data.SqlClient; // para poder enviar comando desde visual a sql

namespace Proyecto_Budget.Control
{
    class CRUD_Producto
    {
        public static Conexion.ConexionDB controlDB = new Conexion.ConexionDB();

        public DataTable MostrarProductos()
        {
            DataTable DtProductos = new DataTable("Producto");
            controlDB.MostrarProductos(DtProductos);
            return DtProductos;
        }
    }
}
