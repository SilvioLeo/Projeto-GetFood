
namespace GetFood_Projeto
{
    partial class ControleEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConId = new System.Windows.Forms.TextBox();
            this.txtConAlimento = new System.Windows.Forms.TextBox();
            this.txtConQuantidade = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtpFabricacao = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data de Fabricação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data de Vencimento:";
            // 
            // txtConId
            // 
            this.txtConId.Location = new System.Drawing.Point(122, 23);
            this.txtConId.Name = "txtConId";
            this.txtConId.Size = new System.Drawing.Size(100, 20);
            this.txtConId.TabIndex = 1;
            // 
            // txtConAlimento
            // 
            this.txtConAlimento.Location = new System.Drawing.Point(122, 56);
            this.txtConAlimento.Name = "txtConAlimento";
            this.txtConAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtConAlimento.TabIndex = 1;
            // 
            // txtConQuantidade
            // 
            this.txtConQuantidade.Location = new System.Drawing.Point(122, 82);
            this.txtConQuantidade.Name = "txtConQuantidade";
            this.txtConQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtConQuantidade.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(125, 204);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(222, 204);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(327, 204);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dtpFabricacao
            // 
            this.dtpFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFabricacao.Location = new System.Drawing.Point(125, 109);
            this.dtpFabricacao.Name = "dtpFabricacao";
            this.dtpFabricacao.Size = new System.Drawing.Size(200, 20);
            this.dtpFabricacao.TabIndex = 3;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(125, 136);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimento.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(419, 204);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.dtpFabricacao);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtConQuantidade);
            this.Controls.Add(this.txtConAlimento);
            this.Controls.Add(this.txtConId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControleEstoque";
            this.Text = "ControleEstoque";
            this.Load += new System.EventHandler(this.ControleEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConId;
        private System.Windows.Forms.TextBox txtConAlimento;
        private System.Windows.Forms.TextBox txtConQuantidade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DateTimePicker dtpFabricacao;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}