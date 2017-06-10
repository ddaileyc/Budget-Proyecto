using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // para trabajar con datos de sql
using System.Data.SqlClient; // para poder enviar comando desde visual a sql

namespace Proyecto_Budget.Control
{
    class CRUD
    {
        //funcion para mostrar Productos
        public static DataTable MostrarProducto()
        {

            DataTable DtResultado = new DataTable("Producto");
            SqlConnection SQLconexion = new SqlConnection();

            try
            {
                SQLconexion.ConnectionString = Conexion.ConexionDB.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SQLconexion;
                SqlCmd.CommandText = "spMostrarProducto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;

        }//fin MostrarProducto


    }//fin crud
}//fin proyecto
