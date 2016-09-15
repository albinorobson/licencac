using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.DAO
{
    class DAOParceiro
    {
        private static Postgresql bd = new Postgresql();

        public List<ClsParceiro> preenchelista(String sql)
        {
            try
            {
                List<ClsParceiro> lista = new List<ClsParceiro>();
                
                Npgsql.NpgsqlDataReader dt;

                dt = bd.retornadados(sql);

                while (dt.Read())
                {
                    ClsParceiro parceiro = new ClsParceiro();
                    parceiro.Id_parceiro = dt.GetInt64(dt.GetOrdinal( 0) ;
                    parceiro.Nome_parceiro = dt.GetString(1);
                    lista.Add(parceiro);
                }
                return lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
