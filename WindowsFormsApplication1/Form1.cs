using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void preenchedtcliente()
        {
            List<ClsParceiro> lista = new List<ClsParceiro>();
            DAOParceiro dao = new DAOParceiro();
            lista = dao.preenchelista("select * from parceiro order by id_parceiro");
            dtcliente.DataSource = lista;
            dtcliente.Columns["id_parceiro"].HeaderText = "Código";
            dtcliente.Columns["nome_parceiro"].HeaderText = "Nome Parceiro";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preenchedtcliente();
        }

    }
}
