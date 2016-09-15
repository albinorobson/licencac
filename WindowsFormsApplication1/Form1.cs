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
            List<ClsCliente> lista = new List<ClsCliente>();
            DAOCliente dao = new DAOCliente();
            lista = dao.preenchelistacliente("select * from cliente where cnpj is not null order by id_cliente");

            //dtcliente.DataSource = lista;
            //dtcliente.Columns["id_parceiro"].HeaderText = "Código";
            //dtcliente.Columns["nome_parceiro"].HeaderText = "Nome Parceiro";

            //datagrid1.DataSource = lista;
            //datagrid1.Columns["id_parceiro"].HeaderText = "Código";
            //datagrid1.Columns["nome_parceiro"].HeaderText = "Nome Parceiro";

            bdCliente.DataSource = lista;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preenchedtcliente();
        }

    }
}
