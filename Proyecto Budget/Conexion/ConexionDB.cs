using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Budget.Conexion
{
    class ConexionDB
    {
        public static string conexion = "Server=tcp:db-budget.database.windows.net,1433;Database=Budget;User ID=budget-admin;Password=p455w0rD;Encrypt=True";

        #region "Metodo validacion usuario"
        public Boolean ValidarUsuario(string usuarioDB, string contrasenaDB)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spValidarUsuario";
                cmd.Parameters.AddWithValue("@usuario", usuarioDB);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaDB);
                SQLconexion.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region "Metodos de muestra de datos"
        public DataTable MostrarProductos(DataTable productos)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                SQLconexion.Open();
                cmd.Connection = SQLconexion;
                cmd.CommandText = "spMostrarProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(productos);
                SQLconexion.Close();
            }
            catch (Exception)
            {
                productos = null;
            }
            return productos;
        }

        public DataTable MostrarProveedores(DataTable proveedores)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                SQLconexion.Open();
                cmd.Connection = SQLconexion;
                cmd.CommandText = "spMostrarProveedores";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(proveedores);
                SQLconexion.Close();
            }
            catch (Exception)
            {
                proveedores = null;
            }
            return proveedores;
        }
        #endregion

        #region "Metodos de insercion de datos"
        public void insertarProducto(Control.CRUD_Producto producto)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsertarProducto";
                cmd.Parameters.AddWithValue("@Nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.desc);
                cmd.Parameters.AddWithValue("@Marca", producto.marca);
                cmd.Parameters.AddWithValue("@Costo", producto.costo);
                cmd.Parameters.AddWithValue("@Proveedor", producto.proveedor);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Producto agregado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar producto", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertarProveedor(Control.CRUD_Proveedor proveedor)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsertarProveedor";
                cmd.Parameters.AddWithValue("@Nombre", proveedor.nombre);
                cmd.Parameters.AddWithValue("@Cedula", proveedor.cedula);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.direccion);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.telefono);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Proveedor agregado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar proveedor", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region "Metodos de elmiminacion de datos"
        public void eliminarProducto(int iddb)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spEliminarProducto";
                cmd.Parameters.AddWithValue("@Id", iddb);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar producto", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void eliminarProveedor(int iddb)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spEliminarProveedor";
                cmd.Parameters.AddWithValue("@Id", iddb);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Proveedor eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar proveedor", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region "Metodos de modificacion de datos"
        public void modificarProducto(Control.CRUD_Producto productodb)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spModificarProducto";
                cmd.Parameters.AddWithValue("@Nombre", productodb.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", productodb.desc);
                cmd.Parameters.AddWithValue("@Marca", productodb.marca);
                cmd.Parameters.AddWithValue("@Proveedor", productodb.proveedor);
                cmd.Parameters.AddWithValue("@Costo", productodb.costo);
                cmd.Parameters.AddWithValue("@Id", productodb.id);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Producto modificado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar producto", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void modificarProveedor(Control.CRUD_Proveedor proveedordb)
        {
            SqlConnection SQLconexion = new SqlConnection();
            try
            {
                SQLconexion.ConnectionString = ConexionDB.conexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLconexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spModificarProveedor";
                cmd.Parameters.AddWithValue("@Nombre", proveedordb.nombre);
                cmd.Parameters.AddWithValue("@Direccion", proveedordb.direccion);
                cmd.Parameters.AddWithValue("@Cedula", proveedordb.cedula);
                cmd.Parameters.AddWithValue("@Telefono", proveedordb.telefono);
                cmd.Parameters.AddWithValue("@Id", proveedordb.id);
                cmd.CommandTimeout = 0;
                SQLconexion.Open();
                int CantidadRegistro = cmd.ExecuteNonQuery();
                if (CantidadRegistro > 0)
                {
                    MessageBox.Show("Proveedor modificado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar proveedor", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
