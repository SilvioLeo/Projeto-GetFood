using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFood_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0MNCEOGP\SQLEXPRESS;Initial Catalog=GetFood_DatBase;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tabela_Usuarios WHERE email = '" + txtLoginEmail.Text.Trim() + "' AND senha = '" + txtLoginSenha.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                ControleEstoque controleEstoque = new ControleEstoque();
                controleEstoque.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Verifique se o email e senha estão corretos!!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
           


        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
