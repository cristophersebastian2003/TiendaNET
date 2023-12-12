﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{

    public class DBAccess
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AccesoTiendaNET"].ConnectionString);

        public DataTable ListarDatos(string v)
        {
            throw new NotImplementedException();
        }

        public SqlConnection getConexion()
        {
            return this.conexion;
        }

        public void abrirConexion()
        {
            if (this.conexion.State == ConnectionState.Closed)
            {
                this.conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if (this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }

        public DataTable ListarDatos(string spu, string v, int idcategoria)
        {
            DataTable dt = new DataTable();
            this.abrirConexion();
            SqlCommand comando = new SqlCommand(spu, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();
            return dt;
        }
        public DataTable ListarDatosVariables(string spu, string nombreVariable, object valorVariable)
        {
            DataTable dt = new DataTable();
            this.abrirConexion();
            SqlCommand comando = new SqlCommand(spu, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(nombreVariable, valorVariable);
            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();
            return dt;

        }
    }
}


 

