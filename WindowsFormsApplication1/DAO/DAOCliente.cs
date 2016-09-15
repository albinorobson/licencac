using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.DAO
{
    class DAOCliente
    {
        private static Postgresql bd = new Postgresql();

        public List<ClsCliente> preenchelistacliente(String sql)
        {
            try
            {
                List<ClsCliente> lista = new List<ClsCliente>();

                Npgsql.NpgsqlDataReader dt;

                dt = bd.retornadados(sql);

                while (dt.Read())
                {
                    ClsCliente cliente = new ClsCliente();
                    cliente.Id_cliente = dt.GetInt64(0);
                    cliente.Nome = dt.GetString(1);
                    if (!dt.IsDBNull(2))
                    cliente.Serialnumberhd = dt.GetString(2);
                    if (!dt.IsDBNull(3))
                    cliente.Dtlastverify = (DateTime) dt.GetTimeStamp(3);
                    cliente.Atualizado = dt.GetBoolean(4);
                    cliente.Cnpj = dt.GetString(5);
                    cliente.Datacriado = (DateTime)dt.GetTimeStamp(6);
                    if(!dt.IsDBNull(7))
                    cliente.Parceiro.Nome_parceiro = dt.GetString(7);

                    lista.Add(cliente);
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
