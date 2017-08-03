using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Budget.Control
{
    public class CRUD_Presupuesto
    {
        public void insertarPresupuesto(Modelo.Presupuesto presupuesto)
        {
        Conexion.ConexionDB controlDBPresupuesto = new Conexion.ConexionDB();
        controlDBPresupuesto.insertarPresupuesto(presupuesto);
        }

        public void eliminarPresupuesto(Modelo.Presupuesto presupuesto)
        {
            Conexion.ConexionDB controlDBPresupuesto = new Conexion.ConexionDB();
            controlDBPresupuesto.eliminarPresupuesto(presupuesto);
        }
    }
}
