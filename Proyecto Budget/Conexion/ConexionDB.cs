using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Budget.Conexion
{
    class ConexionDB
    {
        public static string conexion = "Server=tcp:db-budget.database.windows.net,1433;Database=Budget;User ID=budget-admin;Password=p455w0rD;Encrypt=True";


        //Metodo de validacion de usuario para login
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

        //Metodos de muestra de datos
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
    }
}
