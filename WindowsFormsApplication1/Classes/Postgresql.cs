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
                    conn.ConnectionString = ("Server=postgresql01.cervantestecnologia.hospedagemdesites.ws;Port=5432;Database=cervantestecno1;User Id=cervantestecno1;Password=MA5463890ET;");
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
                if (cmd == null)
                {
                    getcmd();
                }
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
                if (cmd == null)
                {
                    getcmd();
                }
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
