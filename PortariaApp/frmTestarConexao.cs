using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void frmTestarConexao_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Iniciando a classe de conexão do mysql
            MySqlConnection conn = new MySqlConnection();
            //ciando a string da conexão
            conn.ConnectionString = "Server=Localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
            //abrindo o banco de dados
            try 
            { 
                conn.Open();
                lblStatus.Text = "Banco conectado com sucesso";
            }
            catch (MySqlException)
            {
                lblStatus.Text = "Erro ao conectar";
            }
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Iniciando a classe de conexão do mysql
            MySqlConnection conn = new MySqlConnection();
            conn.Close();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
