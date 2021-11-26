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
    public partial class ControleEstoque : Form
    {
        public ControleEstoque()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0MNCEOGP\SQLEXPRESS;Initial Catalog=GetFood_DatBase;Integrated Security=True");

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int idAlimento = int.Parse(txtConId.Text);
            string alimento = txtConAlimento.Text, quantidade = txtConQuantidade.Text;
            DateTime dataF = DateTime.Parse(dtpFabricacao.Text), dataV = DateTime.Parse(dtpVencimento.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("EXEC Inserir_Alimento '"+ idAlimento + "','" + alimento + "','" + quantidade + "','" + dataF + "','" + dataV + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserido com sucesso!!!");
            MostrarGrid();
        }

        private void MostrarGrid()
        {
            SqlCommand cmd = new SqlCommand("EXEC Listar_Alimento", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void ControleEstoque_Load(object sender, EventArgs e)
        {
            MostrarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int idAlimento = int.Parse(txtConId.Text);
            string alimento = txtConAlimento.Text, quantidade = txtConQuantidade.Text;
            DateTime dataF = DateTime.Parse(dtpFabricacao.Text), dataV = DateTime.Parse(dtpVencimento.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("EXEC Atualizar_Alimento '" + idAlimento + "','" + alimento + "','" + quantidade + "','" + dataF + "','" + dataV + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Atualizado com sucesso!!!");
            MostrarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que quer deletar?","Deletar alimentos",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                int idAlimento = int.Parse(txtConId.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC Deletar_Alimento '" + idAlimento + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deletado com sucesso!!!");
                MostrarGrid();
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            int idAlimento = int.Parse(txtConId.Text);

            SqlCommand cmd = new SqlCommand("EXEC Consultar_Alimento '" + idAlimento + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
