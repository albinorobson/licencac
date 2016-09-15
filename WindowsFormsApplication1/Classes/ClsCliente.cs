using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class ClsCliente
    {
        #region Atributos

        private long _id_cliente;
        private string _nome;
        private string _serialnumberhd;
        private DateTime _dtlastverify;
        private Boolean _atualizado;
        private string _cnpj;
        private DateTime _datacriado;
        private ClsParceiro _parceiro = new ClsParceiro();

        #endregion

        #region Construtor

        public ClsCliente()
        {

        }
        #endregion

        #region Propriedades
        public long Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Serialnumberhd
        {
            get { return _serialnumberhd; }
            set { _serialnumberhd = value; }
        }
        public DateTime Dtlastverify
        {
            get { return _dtlastverify; }
            set { _dtlastverify = value; }
        }
        public Boolean Atualizado
        {
            get { return _atualizado; }
            set { _atualizado = value; }
        }
        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        public DateTime Datacriado
        {
            get { return _datacriado; }
            set { _datacriado = value; }
        }
        internal ClsParceiro Parceiro
        {
            get { return _parceiro; }
            set { _parceiro = value; }
        }
        #endregion

        
        

    }
}
