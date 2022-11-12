using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Proyecto_BancoRediseñado3
{    
    class HelperDAO
    {
        private static HelperDAO Instancia;
        private string Conexion;

        private HelperDAO()
        {
            Conexion = Properties.Resources.StringConnection;
        }
        
        public static HelperDAO ObtenerInstancia()
        {
            if (Instancia == null)
                Instancia = new HelperDAO();
            return Instancia;
        }

        public DataTable ConsultarDB(string SP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }

        public DataTable ConsultaDBParametros(string SP, string Nombre,object Valor)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue(Nombre, Valor);
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();   
            }
            
        }


        public int Transaccion(string SP,List<Parametros> lParametros)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            int filasAfectadas = 0;
            try
            {
                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = SP;
                cmd.Parameters.Clear();
                foreach (Parametros p in lParametros)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                filasAfectadas = cmd.ExecuteNonQuery();                
                t.Commit();
                return filasAfectadas;
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }                
         
        }

        public int BajaLogica(int Cbu, string estado)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();            
            SqlTransaction t = null;            
            int filasAfectadas = 0;
            try
            {
                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "BajaLogica";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cbu", Cbu);
                cmd.Parameters.AddWithValue("@estado", estado);
                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();             
                return filasAfectadas;
            }
            catch(SqlException ex)
            {
                t.Rollback();
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }
    }

}
