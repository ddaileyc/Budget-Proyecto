using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // para trabajar con datos de sql
using System.Data.SqlClient; // para poder enviar comando desde visual a sql

namespace Proyecto_Budget.Control
{
    class CRUD_Proveedor
    {
        public static Conexion.ConexionDB controlDBProveedor = new Conexion.ConexionDB();

        public static DataTable MostrarProveedores()
        {
            DataTable DtProveedores = new DataTable("Proveedores");
            controlDBProveedor.MostrarProveedores(DtProveedores);
            return DtProveedores;
        }
    }
}