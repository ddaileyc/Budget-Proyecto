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

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            return controlDBUsuario.ValidarUsuario(usuario, contrasena);
        }

        public void eliminarUsuario(Modelo.Usuario usuario)
        {
            controlDBUsuario.eliminarUsuario(usuario);
        }
    }
}