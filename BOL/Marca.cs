using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BOL
{
   public class Marca
    {
        DBAccess conexion = new DBAccess();
        public DataTable Listar()
        {
            return conexion.ListarDatos("spu_Marcas_listar");
            
        }
    }
}
