using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Budget.Control
{
   public  class User_controller
    {

        public string AddUser(User user)
        {
            DataTable dt = new DataTable();
            string consulta;
            string res = "Agregado exitosamente";
            consulta = "insert into User values(" + user.id + "," + user.Nombre + "," + user.Apellidos + "," + user.Departamento + "," + user.tipo + ",true)";
            adapter.consulta(consulta);


            return res;
        }

        public DataTable SearchUser(string id)
        {
            DataTable dt = new DataTable();
            string consulta;

            consulta = "select * from User where id=" + id;

            dt = adapter.consulta(consulta);
            return dt;
        }

        public string UpdateUser (string id)
        {
            string res = "Modificado exitosamente";
            string consulta;

            consulta = "";
            adapter.consultar(consulta);
            return res;


        }

        public string DisposeUser(string id)
        {
            string res, consulta;
            res = "Usuario eliminado exitosamente";
            consulta = "update set Actvo= false from User where id="+id;
            return res;
        }
    }
}
