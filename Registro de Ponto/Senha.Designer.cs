namespace Registro_de_Ponto
{
    partial class Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Senha));
            this.novaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cNovaSenha = new System.Windows.Forms.TextBox();
            this.confirmaSenha = new System.Windows.Forms.Button();
            this.cancelarSenha = new System.Windows.Forms.Button();
            this.mostraSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // novaSenha
            // 
            this.novaSenha.Location = new System.Drawing.Point(137, 31);
            this.novaSenha.Name = "novaSenha";
            this.novaSenha.PasswordChar = '*';
            this.novaSenha.Size = new System.Drawing.Size(199, 20);
            this.novaSenha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirme a senha:";
            // 
            // cNovaSenha
            // 
            this.cNovaSenha.Location = new System.Drawing.Point(137, 78);
            this.cNovaSenha.Name = "cNovaSenha";
            this.cNovaSenha.PasswordChar = '*';
            this.cNovaSenha.Size = new System.Drawing.Size(199, 20);
            this.cNovaSenha.TabIndex = 3;
            // 
            // confirmaSenha
            // 
            this.confirmaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.confirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.confirmaSenha.ForeColor = System.Drawing.Color.White;
            this.confirmaSenha.Location = new System.Drawing.Point(101, 143);
            this.confirmaSenha.Name = "confirmaSenha";
            this.confirmaSenha.Size = new System.Drawing.Size(102, 36);
            this.confirmaSenha.TabIndex = 4;
            this.confirmaSenha.Text = "Alterar";
            this.confirmaSenha.UseVisualStyleBackColor = false;
            this.confirmaSenha.Click += new System.EventHandler(this.confirmaSenha_Click);
            // 
            // cancelarSenha
            // 
            this.cancelarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.cancelarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cancelarSenha.ForeColor = System.Drawing.Color.White;
            this.cancelarSenha.Location = new System.Drawing.Point(251, 143);
            this.cancelarSenha.Name = "cancelarSenha";
            this.cancelarSenha.Size = new System.Drawing.Size(102, 36);
            this.cancelarSenha.TabIndex = 5;
            this.cancelarSenha.Text = "Cancelar";
            this.cancelarSenha.UseVisualStyleBackColor = false;
            this.cancelarSenha.Click += new System.EventHandler(this.cancelarSenha_Click);
            // 
            // mostraSenha
            // 
            this.mostraSenha.AutoSize = true;
            this.mostraSenha.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.mostraSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.mostraSenha.Location = new System.Drawing.Point(342, 78);
            this.mostraSenha.Name = "mostraSenha";
            this.mostraSenha.Size = new System.Drawing.Size(101, 19);
            this.mostraSenha.TabIndex = 11;
            this.mostraSenha.Text = "Mostrar senha";
            this.mostraSenha.UseVisualStyleBackColor = true;
            this.mostraSenha.CheckedChanged += new System.EventHandler(this.mostraSenha_CheckedChanged);
            // 
            // Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 206);
            this.Controls.Add(this.mostraSenha);
            this.Controls.Add(this.cancelarSenha);
            this.Controls.Add(this.confirmaSenha);
            this.Controls.Add(this.cNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.novaSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox novaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cNovaSenha;
        private System.Windows.Forms.Button confirmaSenha;
        private System.Windows.Forms.Button cancelarSenha;
        private System.Windows.Forms.CheckBox mostraSenha;
    }
}