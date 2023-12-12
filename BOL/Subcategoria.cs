using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;
using System.Data.SqlClient;
namespace BOL
{
    public class Subcategoria
    {
        DBAccess conexion = new DBAccess();
        public DataTable Listar(int idcategoria)
        {
            return conexion.ListarDatos("spu_Subcategorias_listar", "@idcategoria", idcategoria);

        }

       
      

    }
}
