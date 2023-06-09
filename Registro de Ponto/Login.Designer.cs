namespace Registro_de_Ponto
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mostraSenha = new System.Windows.Forms.CheckBox();
            this.loginEntrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSuper = new System.Windows.Forms.RadioButton();
            this.radioFunc = new System.Windows.Forms.RadioButton();
            this.senha = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mostraSenha);
            this.panel1.Controls.Add(this.loginEntrar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 386);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 22.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(73, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "TimeTrackPro";
            // 
            // mostraSenha
            // 
            this.mostraSenha.AutoSize = true;
            this.mostraSenha.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.mostraSenha.ForeColor = System.Drawing.Color.White;
            this.mostraSenha.Location = new System.Drawing.Point(33, 281);
            this.mostraSenha.Name = "mostraSenha";
            this.mostraSenha.Size = new System.Drawing.Size(101, 19);
            this.mostraSenha.TabIndex = 10;
            this.mostraSenha.Text = "Mostrar senha";
            this.mostraSenha.UseVisualStyleBackColor = true;
            this.mostraSenha.CheckedChanged += new System.EventHandler(this.mostraSenha_CheckedChanged);
            // 
            // loginEntrar
            // 
            this.loginEntrar.Location = new System.Drawing.Point(54, 324);
            this.loginEntrar.Name = "loginEntrar";
            this.loginEntrar.Size = new System.Drawing.Size(186, 35);
            this.loginEntrar.TabIndex = 7;
            this.loginEntrar.Text = "ENTRAR";
            this.loginEntrar.UseVisualStyleBackColor = true;
            this.loginEntrar.Click += new System.EventHandler(this.loginEntrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSuper);
            this.groupBox1.Controls.Add(this.radioFunc);
            this.groupBox1.Location = new System.Drawing.Point(33, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioSuper
            // 
            this.radioSuper.AutoSize = true;
            this.radioSuper.ForeColor = System.Drawing.Color.White;
            this.radioSuper.Location = new System.Drawing.Point(132, 20);
            this.radioSuper.Name = "radioSuper";
            this.radioSuper.Size = new System.Drawing.Size(75, 17);
            this.radioSuper.TabIndex = 1;
            this.radioSuper.TabStop = true;
            this.radioSuper.Text = "Supervisor";
            this.radioSuper.UseVisualStyleBackColor = true;
            // 
            // radioFunc
            // 
            this.radioFunc.AutoSize = true;
            this.radioFunc.ForeColor = System.Drawing.Color.White;
            this.radioFunc.Location = new System.Drawing.Point(21, 20);
            this.radioFunc.Name = "radioFunc";
            this.radioFunc.Size = new System.Drawing.Size(80, 17);
            this.radioFunc.TabIndex = 0;
            this.radioFunc.TabStop = true;
            this.radioFunc.Text = "Funcionário";
            this.radioFunc.UseVisualStyleBackColor = true;
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(33, 246);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(234, 29);
            this.senha.TabIndex = 4;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.usuario.Location = new System.Drawing.Point(33, 175);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(234, 29);
            this.usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de ponto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioSuper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFunc;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginEntrar;
        private System.Windows.Forms.CheckBox mostraSenha;
        private System.Windows.Forms.Label label4;
    }
}

