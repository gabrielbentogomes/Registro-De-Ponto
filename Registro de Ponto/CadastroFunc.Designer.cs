namespace Registro_de_Ponto
{
    partial class CadastroFunc
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
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.CSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mostraSenha = new System.Windows.Forms.CheckBox();
            this.senhaCadastro = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cargaHoraria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.CSenha);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mostraSenha);
            this.panel1.Controls.Add(this.senhaCadastro);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.matricula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 402);
            this.panel1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(323, 260);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBox2.TabIndex = 21;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(319, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Horário de Saída:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(323, 194);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Horário de Entrada:";
            // 
            // cargaHoraria
            // 
            this.cargaHoraria.Location = new System.Drawing.Point(323, 127);
            this.cargaHoraria.Mask = "00:00";
            this.cargaHoraria.Name = "cargaHoraria";
            this.cargaHoraria.Size = new System.Drawing.Size(58, 20);
            this.cargaHoraria.TabIndex = 17;
            this.cargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cargaHoraria.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carga horária: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 22.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(175, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "TimeTrackPro";
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.senha.Location = new System.Drawing.Point(33, 260);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(234, 29);
            this.senha.TabIndex = 13;
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
            this.button1.Location = new System.Drawing.Point(150, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
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
            // senhaCadastro
            // 
            this.senhaCadastro.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.senhaCadastro.Location = new System.Drawing.Point(33, 194);
            this.senhaCadastro.Multiline = true;
            this.senhaCadastro.Name = "senhaCadastro";
            this.senhaCadastro.Size = new System.Drawing.Size(234, 29);
            this.senhaCadastro.TabIndex = 4;
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Source Sans Pro", 14.25F);
            this.nome.Location = new System.Drawing.Point(33, 127);
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(234, 29);
            this.nome.TabIndex = 3;
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
            // CadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 430);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mostraSenha;
        private System.Windows.Forms.TextBox senhaCadastro;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label CSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cargaHoraria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
    }
}