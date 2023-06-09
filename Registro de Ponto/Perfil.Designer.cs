namespace Registro_de_Ponto
{
    partial class Perfil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControleJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alteraSenha = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.btnPerfil,
            this.btnControleJornada});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(499, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 21);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(119, 21);
            this.btnPerfil.Text = "Perfil do usuário";
            // 
            // btnControleJornada
            // 
            this.btnControleJornada.BackColor = System.Drawing.SystemColors.Control;
            this.btnControleJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleJornada.Name = "btnControleJornada";
            this.btnControleJornada.Size = new System.Drawing.Size(143, 21);
            this.btnControleJornada.Text = "Controle de Jornada";
            this.btnControleJornada.Click += new System.EventHandler(this.btnControleJornada_Click);
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.nomeUsuario.Location = new System.Drawing.Point(92, 47);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.ReadOnly = true;
            this.nomeUsuario.Size = new System.Drawing.Size(328, 20);
            this.nomeUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuário:";
            // 
            // alteraSenha
            // 
            this.alteraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.alteraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.alteraSenha.ForeColor = System.Drawing.Color.White;
            this.alteraSenha.Location = new System.Drawing.Point(140, 106);
            this.alteraSenha.Name = "alteraSenha";
            this.alteraSenha.Size = new System.Drawing.Size(213, 41);
            this.alteraSenha.TabIndex = 13;
            this.alteraSenha.Text = "Alterar Senha";
            this.alteraSenha.UseVisualStyleBackColor = false;
            this.alteraSenha.Click += new System.EventHandler(this.alteraSenha_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 172);
            this.Controls.Add(this.alteraSenha);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnControleJornada;
        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button alteraSenha;
    }
}