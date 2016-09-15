using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class ClsClienteNovo
    {
        #region Atributos

        private string codigo;
        private DateTime vencimento;
        private int nro_licencas;
        private long idclientenovo;
        private ClsCliente cliente = new ClsCliente();

        #endregion

        #region Construtor

        public ClsClienteNovo()
        {
            
        }
        #endregion

        #region Propriedades

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public DateTime Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }
        public int Nro_licencas
        {
            get { return nro_licencas; }
            set { nro_licencas = value; }
        }
        public long Idclientenovo
        {
            get { return idclientenovo; }
            set { idclientenovo = value; }
        }
        internal ClsCliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        #endregion
    }
}
