using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApplication1.Classes
{
    class Postgresql
    {
        #region Atributos

        private static NpgsqlConnection conn = null;
        private static NpgsqlCommand cmd = null;
        private static NpgsqlDataReader dtreader = null;
        
        #endregion

        #region Construtor
        
        public Postgresql()
        {

        }

        #endregion

        #region Conexão

        private NpgsqlCommand getcmd()
        {

            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection();
                    conn.ConnectionString = ("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=postgres;");
                    conn.Open();
                }
                if (cmd == null)
                {
                    cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                }

                return cmd;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Insert,Update,Delete
        
        public void executasql(String sql)
        {
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region CarregaDatareader

        public NpgsqlDataReader retornadados(String sql)
        {
            try
            {
                cmd.CommandText = sql;
                dtreader = cmd.ExecuteReader();

                return dtreader;

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
    }
}
