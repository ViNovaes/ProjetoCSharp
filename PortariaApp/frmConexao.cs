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

    class conexão
    { 
        private static string conString = "server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
        private static MySqlConnection conn = null;
        
        public static MySqlConnection oterConexao()
        {
            conn = new MySqlConnection(conString);

            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }

            return conn;
        }
    }

    public static void fecharConexao()
    {
        if (conn != null)
        {
            conn.Close();
        }
    }

    public partial class frmConexao : Form
    {
        public frmConexao()
        {
            InitializeComponent();
        }
    }
}
