
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
            this.btnCadCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadCadastrar
            // 
            this.btnCadCadastrar.Location = new System.Drawing.Point(199, 185);
            this.btnCadCadastrar.Name = "btnCadCadastrar";
            this.btnCadCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadCadastrar.TabIndex = 3;
            this.btnCadCadastrar.Text = "Cadastrar";
            this.btnCadCadastrar.UseVisualStyleBackColor = true;
            this.btnCadCadastrar.Click += new System.EventHandler(this.btnCadCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Location = new System.Drawing.Point(188, 60);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCadEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(188, 98);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadSenha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirmar senha:";
            // 
            // txtCadConfSenha
            // 
            this.txtCadConfSenha.Location = new System.Drawing.Point(188, 137);
            this.txtCadConfSenha.Name = "txtCadConfSenha";
            this.txtCadConfSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadConfSenha.TabIndex = 2;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 319);
            this.Controls.Add(this.txtCadConfSenha);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadCadastrar);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
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
    }
}