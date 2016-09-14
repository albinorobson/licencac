using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class ClsParceiro
    {
        #region Atributos

        private long _id_parceiro;
        private string _nome_parceiro;
        
        #endregion

        #region Construtor

        public ClsParceiro()
        {

        }

        #endregion

        #region Propriedades

        public long Id_parceiro
        {
            get { return _id_parceiro; }
            set { _id_parceiro = value; }
        }

        public string Nome_parceiro
        {
            get { return _nome_parceiro; }
            set { _nome_parceiro = value; }
        }

        #endregion
       
    }
}
