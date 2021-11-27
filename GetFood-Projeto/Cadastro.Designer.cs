
namespace GetFood_Projeto
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btnCadCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadConfSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadSair = new System.Windows.Forms.Button();
            this.btnCadVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadCadastrar
            // 
            this.btnCadCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadCadastrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadCadastrar.Location = new System.Drawing.Point(349, 231);
            this.btnCadCadastrar.Name = "btnCadCadastrar";
            this.btnCadCadastrar.Size = new System.Drawing.Size(116, 31);
            this.btnCadCadastrar.TabIndex = 3;
            this.btnCadCadastrar.Text = "Cadastrar";
            this.btnCadCadastrar.UseVisualStyleBackColor = false;
            this.btnCadCadastrar.Click += new System.EventHandler(this.btnCadCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadEmail.Location = new System.Drawing.Point(307, 100);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(200, 23);
            this.txtCadEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(307, 142);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(200, 23);
            this.txtCadSenha.TabIndex = 1;
            this.txtCadSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirmar senha:";
            // 
            // txtCadConfSenha
            // 
            this.txtCadConfSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadConfSenha.Location = new System.Drawing.Point(307, 184);
            this.txtCadConfSenha.Name = "txtCadConfSenha";
            this.txtCadConfSenha.Size = new System.Drawing.Size(200, 23);
            this.txtCadConfSenha.TabIndex = 2;
            this.txtCadConfSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "CADASTRO";
            // 
            // btnCadSair
            // 
            this.btnCadSair.BackColor = System.Drawing.Color.Red;
            this.btnCadSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadSair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSair.ForeColor = System.Drawing.Color.White;
            this.btnCadSair.Location = new System.Drawing.Point(558, 12);
            this.btnCadSair.Name = "btnCadSair";
            this.btnCadSair.Size = new System.Drawing.Size(35, 35);
            this.btnCadSair.TabIndex = 6;
            this.btnCadSair.Text = "X";
            this.btnCadSair.UseVisualStyleBackColor = false;
            this.btnCadSair.Click += new System.EventHandler(this.btnCadSair_Click);
            // 
            // btnCadVoltar
            // 
            this.btnCadVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadVoltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVoltar.ForeColor = System.Drawing.Color.White;
            this.btnCadVoltar.Location = new System.Drawing.Point(518, 284);
            this.btnCadVoltar.Name = "btnCadVoltar";
            this.btnCadVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnCadVoltar.TabIndex = 7;
            this.btnCadVoltar.Text = "Voltar";
            this.btnCadVoltar.UseVisualStyleBackColor = false;
            this.btnCadVoltar.Click += new System.EventHandler(this.btnCadVoltar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(605, 319);
            this.Controls.Add(this.btnCadVoltar);
            this.Controls.Add(this.btnCadSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCadConfSenha);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadConfSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadSair;
        private System.Windows.Forms.Button btnCadVoltar;
    }
}