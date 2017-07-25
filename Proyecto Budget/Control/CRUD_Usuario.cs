using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // para trabajar con datos de sql
using System.Data.SqlClient; // para poder enviar comando desde visual a sql

namespace Proyecto_Budget.Control
{
    class CRUD_Usuario
    {
        public static Conexion.ConexionDB controlDBUsuario = new Conexion.ConexionDB();
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int cedula { get; set; }
        public int departamento { get; set; }
        public int puesto { get; set; }
        public string id_sistema { get; set; }
        public string contrasena { get; set; }

        public Boolean ValidarUsuario(string usuario, string contrasena)
        {
            return controlDBUsuario.ValidarUsuario(usuario, contrasena);
        }

        public static DataTable MostrarUsuarios()
        {
            DataTable DtUsuarios = new DataTable("Usuarios");
            controlDBUsuario.MostrarProveedores(DtUsuarios);
            return DtUsuarios;
        }

        //public void insertarUsuario(CRUD_Usuario usuario)
        //{
        //    controlDBUsuario.insertarUsuario(usuario);
        //}

        //public void eliminarUsuario(int id)
        //{
        //    controlDBUsuario.eliminarUsuario(id);
        //}

        //public void modificarUsuario(Control.CRUD_Usuario usuario)
        //{
        //    controlDBUsuario.modificarUsuario(usuario);
        //}
    }
}