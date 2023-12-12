using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; // ACCESO A CONEXION SERVER + DB
using System.Data;  // OBJETOS MANEJADORES DE DATOS - EN LA MEMORIA
using System.Data.SqlClient; // ACCESO 'MSSQL' SERVER
using ENTITIES;

namespace BOL
{
   public class Producto
    {
        DBAccess conexion = new DBAccess();
        
        public  DataTable Listar()
        {
            DataTable dt = new DataTable();
            return conexion.ListarDatos("spu_Productos_listar");
            
        }

        public int registrar(EProducto entProducto)
        {
            throw new NotImplementedException();
        }
    }
    public  int Registrar(EProducto entidad)
    {
        int totalRegistros;
        

        try
        {
            SqlCommand comando = new SqlCommand("spu_Prodcutos_registrar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmarca", entidad.idmarca);
            comando.Parameters.AddWithValue("@idsubcategoria", entidad.idsubcategoria);
            comando.Parameters.AddWithValue("@descripcion", entidad.descripcion);
            comando.Parameters.AddWithValue("@garantia", entidad.garantia);
            comando.Parameters.AddWithValue("@precio", entidad.precio);
            comando.Parameters.AddWithValue("@stock", entidad.stock);

            totalRegistros = comando.ExecuteNonQuery();

        }
        catch
        {
            totalRegistros = -1;
        }
        finally
        {
            conexion.cerrarConexion();
        }
        return totalRegistros;
        
    }
}
