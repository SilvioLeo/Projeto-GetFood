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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0MNCEOGP\SQLEXPRESS;Initial Catalog=GetFood_DatBase;Integrated Security=True");

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {
            if(txtCadEmail.Text == "" || txtCadSenha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos", "Erro ao cadastrar", MessageBoxButtons.OK);

            }
            else
            {

                if (VerificarCadastroUsuario())
                {

                    if (txtCadSenha.Text.Equals(txtCadConfSenha.Text))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO tabela_Usuarios(email, senha) VALUES('" + txtCadEmail.Text.Trim() + "','" + txtCadSenha.Text.Trim() + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cadastrado com sucesso", "Cadastro realizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        ControleEstoque controleEstoque = new ControleEstoque();
                        controleEstoque.Show();

                    }
                    else
                    {
                        MessageBox.Show("Senha e confirmar senha precisão ser iguais", "Senhas não correspondem", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                else
                {
                    MessageBox.Show("Email já cadastrado", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           

        }

        private bool VerificarCadastroUsuario()
        {
            string query = "SELECT * FROM tabela_Usuarios WHERE email = '" + txtCadEmail.Text + "'";
            SqlDataAdapter sda =new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                return false;
            }
            return true;

        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
