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
        public int id { get; set; }
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }

        public DataTable MostrarProveedores()
        {
            DataTable DtProveedores = new DataTable("Proveedores");
            controlDBProveedor.MostrarProveedores(DtProveedores);
            return DtProveedores;
        }

        public void insertarProveedor(CRUD_Proveedor proveedor)
        {
            controlDBProveedor.insertarProveedor(proveedor);
        }

        public void eliminarProveedor(int id)
        {
            controlDBProveedor.eliminarProveedor(id);
        }

        public void modificarProveedor(Control.CRUD_Proveedor proveedor)
        {
            controlDBProveedor.modificarProveedor(proveedor);
        }
    }
}