namespace SistemaGerenciamentoEnergia
{
    partial class Form2
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
            this.textNomelogin = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.BootaoEntrarLogin = new System.Windows.Forms.Button();
            this.BootaoCadastrarLogin = new System.Windows.Forms.Button();
            this.BootaoSairLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // textNomelogin
            // 
            this.textNomelogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomelogin.Location = new System.Drawing.Point(135, 63);
            this.textNomelogin.Name = "textNomelogin";
            this.textNomelogin.Size = new System.Drawing.Size(262, 22);
            this.textNomelogin.TabIndex = 6;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(135, 106);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(262, 26);
            this.textSenha.TabIndex = 7;
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // BootaoEntrarLogin
            // 
            this.BootaoEntrarLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.BootaoEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BootaoEntrarLogin.Location = new System.Drawing.Point(200, 138);
            this.BootaoEntrarLogin.Name = "BootaoEntrarLogin";
            this.BootaoEntrarLogin.Size = new System.Drawing.Size(115, 33);
            this.BootaoEntrarLogin.TabIndex = 8;
            this.BootaoEntrarLogin.Text = "Entrar";
            this.BootaoEntrarLogin.UseVisualStyleBackColor = false;
            this.BootaoEntrarLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // BootaoCadastrarLogin
            // 
            this.BootaoCadastrarLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.BootaoCadastrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BootaoCadastrarLogin.Location = new System.Drawing.Point(135, 208);
            this.BootaoCadastrarLogin.Name = "BootaoCadastrarLogin";
            this.BootaoCadastrarLogin.Size = new System.Drawing.Size(115, 33);
            this.BootaoCadastrarLogin.TabIndex = 10;
            this.BootaoCadastrarLogin.Text = "Fazer cadastro";
            this.BootaoCadastrarLogin.UseVisualStyleBackColor = false;
            this.BootaoCadastrarLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // BootaoSairLogin
            // 
            this.BootaoSairLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.BootaoSairLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BootaoSairLogin.Location = new System.Drawing.Point(273, 208);
            this.BootaoSairLogin.Name = "BootaoSairLogin";
            this.BootaoSairLogin.Size = new System.Drawing.Size(101, 33);
            this.BootaoSairLogin.TabIndex = 11;
            this.BootaoSairLogin.Text = "Sair";
            this.BootaoSairLogin.UseVisualStyleBackColor = false;
            this.BootaoSairLogin.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(225, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Login";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::SistemaGerenciamentoEnergia.Properties.Resources.fundo_05;
            this.ClientSize = new System.Drawing.Size(500, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BootaoSairLogin);
            this.Controls.Add(this.BootaoCadastrarLogin);
            this.Controls.Add(this.BootaoEntrarLogin);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNomelogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomelogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button BootaoEntrarLogin;
        private System.Windows.Forms.Button BootaoCadastrarLogin;
        private System.Windows.Forms.Button BootaoSairLogin;
        private System.Windows.Forms.Label label4;
    }
}