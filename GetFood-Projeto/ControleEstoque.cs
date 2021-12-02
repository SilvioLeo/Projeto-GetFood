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
            if (VerificarIdAlimento())
            {
                if(txtConId.Text == "")
                {
                    MessageBox.Show("Prencha todos os campos", "erro ao inserir", MessageBoxButtons.OK);

                }
                else
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
                    LimparCampos();

                }

            }
            else
            {
                MessageBox.Show("Id já cadastrado", "Insira  outro id", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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

            if(txtConId.Text == "")
            {
                MessageBox.Show("Insira o id do alimento que deseje atualizar", "erro ao atualizar", MessageBoxButtons.OK);

            }
            else
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if(txtConId.Text == "")
            {
                MessageBox.Show("Digite o id do alimento que deseje deletar", "erro ao deletar", MessageBoxButtons.OK);

            }
            else
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
                    LimparCampos();
                }


            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtConId.Text == "")
            {

                MessageBox.Show("Primeiro digite um id para consultar", "Didite um id", MessageBoxButtons.OK);
               
            }
            else
            {
               

                int idAlimento = int.Parse(txtConId.Text);

                SqlCommand cmd = new SqlCommand("EXEC Consultar_Alimento '" + idAlimento + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void btnCadLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MostrarGrid();
        }

        private void LimparCampos()
        {
            txtConId.Clear();
            txtConAlimento.Clear();
            txtConQuantidade.Clear();
            dtpFabricacao.ResetText();
            dtpVencimento.ResetText();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Text = Convert.ToString(dgvMenuAlimentos.Rows[e.RowIndex].Cells[0].Value);
            txtConId.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtConAlimento.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            txtConQuantidade.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dtpFabricacao.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            dtpVencimento.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private bool VerificarIdAlimento()
        {
            string query = "SELECT * FROM tabela_Alimentos WHERE id_Alimentos = '" + txtConId.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return false;
            }
            return true;

        }
    }
}
