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
        public static Conexion.ConexionDB controlDBProducto = new Conexion.ConexionDB();
        public int id { get; set;}
        public string nombre { get; set; }
        public string desc { get; set; }
        public string marca { get; set; }
        public double costo { get; set; }
        public int proveedor { get; set; }

        public DataTable MostrarProductos()
        {
            DataTable DtProductos = new DataTable("Productos");
            controlDBProducto.MostrarProductos(DtProductos);
            return DtProductos;
        }

        public void insertarProducto(CRUD_Producto producto)
        {
            controlDBProducto.insertarProducto(producto);
        }

        public void eliminarProducto(int id)
        {
            controlDBProducto.eliminarProducto(id);
        }

        public void modificarProducto(Control.CRUD_Producto producto)
        {
            controlDBProducto.modificarProducto(producto);
        }
    }
}