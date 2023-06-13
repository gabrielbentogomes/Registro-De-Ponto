namespace Registro_de_Ponto
{
    partial class CadastroAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.senhaCadastro = new System.Windows.Forms.TextBox();
            this.CSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mostraSenha = new System.Windows.Forms.CheckBox();
            this.matriculaCadastro = new System.Windows.Forms.TextBox();
            this.nomeCadastro = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.senhaCadastro);
            this.panel1.Controls.Add(this.CSenha);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mostraSenha);
            this.panel1.Controls.Add(this.matriculaCadastro);
            this.panel1.Controls.Add(this.nomeCadastro);
            this.panel1.Controls.Add(this.matricula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 402);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 22.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(74, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "TimeTrackPro";
            // 
            // senhaCadastro
            // 
            this.senhaCadastro.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.senhaCadastro.Location = new System.Drawing.Point(33, 260);
            this.senhaCadastro.Multiline = true;
            this.senhaCadastro.Name = "senhaCadastro";
            this.senhaCadastro.PasswordChar = '*';
            this.senhaCadastro.Size = new System.Drawing.Size(234, 29);
            this.senhaCadastro.TabIndex = 13;
            // 
            // CSenha
            // 
            this.CSenha.AutoSize = true;
            this.CSenha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSenha.ForeColor = System.Drawing.Color.White;
            this.CSenha.Location = new System.Drawing.Point(29, 236);
            this.CSenha.Name = "CSenha";
            this.CSenha.Size = new System.Drawing.Size(62, 21);
            this.CSenha.TabIndex = 12;
            this.CSenha.Text = "Senha: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostraSenha
            // 
            this.mostraSenha.AutoSize = true;
            this.mostraSenha.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.mostraSenha.ForeColor = System.Drawing.Color.White;
            this.mostraSenha.Location = new System.Drawing.Point(33, 295);
            this.mostraSenha.Name = "mostraSenha";
            this.mostraSenha.Size = new System.Drawing.Size(101, 19);
            this.mostraSenha.TabIndex = 6;
            this.mostraSenha.Text = "Mostrar senha";
            this.mostraSenha.UseVisualStyleBackColor = true;
            this.mostraSenha.CheckedChanged += new System.EventHandler(this.mostraSenha_CheckedChanged);
            // 
            // matriculaCadastro
            // 
            this.matriculaCadastro.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.matriculaCadastro.Location = new System.Drawing.Point(33, 194);
            this.matriculaCadastro.Multiline = true;
            this.matriculaCadastro.Name = "matriculaCadastro";
            this.matriculaCadastro.Size = new System.Drawing.Size(234, 29);
            this.matriculaCadastro.TabIndex = 4;
            // 
            // nomeCadastro
            // 
            this.nomeCadastro.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.nomeCadastro.Location = new System.Drawing.Point(33, 127);
            this.nomeCadastro.Multiline = true;
            this.nomeCadastro.Name = "nomeCadastro";
            this.nomeCadastro.Size = new System.Drawing.Size(234, 29);
            this.nomeCadastro.TabIndex = 3;
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.ForeColor = System.Drawing.Color.White;
            this.matricula.Location = new System.Drawing.Point(29, 170);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(82, 21);
            this.matricula.TabIndex = 2;
            this.matricula.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo: ";
            // 
            // CadastroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 430);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhaCadastro;
        private System.Windows.Forms.Label CSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mostraSenha;
        private System.Windows.Forms.TextBox matriculaCadastro;
        private System.Windows.Forms.TextBox nomeCadastro;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.Label label1;
    }
}