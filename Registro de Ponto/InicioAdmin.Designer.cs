namespace Registro_de_Ponto
{
    partial class Inicio_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastroAdmin = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btntratarPonto = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControleJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem-Vindo(a) a página inicial!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastroAdmin);
            this.panel1.Controls.Add(this.btnBanco);
            this.panel1.Controls.Add(this.btntratarPonto);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Location = new System.Drawing.Point(209, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 214);
            this.panel1.TabIndex = 5;
            // 
            // btnCadastroAdmin
            // 
            this.btnCadastroAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnCadastroAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCadastroAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCadastroAdmin.Location = new System.Drawing.Point(38, 27);
            this.btnCadastroAdmin.Name = "btnCadastroAdmin";
            this.btnCadastroAdmin.Size = new System.Drawing.Size(294, 34);
            this.btnCadastroAdmin.TabIndex = 7;
            this.btnCadastroAdmin.Text = "Cadastrar administrador";
            this.btnCadastroAdmin.UseVisualStyleBackColor = false;
            this.btnCadastroAdmin.Click += new System.EventHandler(this.btnCadastroAdmin_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.ForeColor = System.Drawing.Color.White;
            this.btnBanco.Location = new System.Drawing.Point(38, 147);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(294, 34);
            this.btnBanco.TabIndex = 5;
            this.btnBanco.Text = "Banco de horas";
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btntratarPonto
            // 
            this.btntratarPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btntratarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntratarPonto.ForeColor = System.Drawing.Color.White;
            this.btntratarPonto.Location = new System.Drawing.Point(38, 107);
            this.btntratarPonto.Name = "btntratarPonto";
            this.btntratarPonto.Size = new System.Drawing.Size(294, 34);
            this.btntratarPonto.TabIndex = 4;
            this.btntratarPonto.Text = "Tratar ponto";
            this.btntratarPonto.UseVisualStyleBackColor = false;
            this.btntratarPonto.Click += new System.EventHandler(this.btntratarPonto_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(38, 67);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(294, 34);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastrar funcionário";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
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
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(119, 21);
            this.btnPerfil.Text = "Perfil do usuário";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnControleJornada
            // 
            this.btnControleJornada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControleJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleJornada.Name = "btnControleJornada";
            this.btnControleJornada.Size = new System.Drawing.Size(143, 21);
            this.btnControleJornada.Text = "Controle de Jornada";
            // 
            // Inicio_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btntratarPonto;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnControleJornada;
        private System.Windows.Forms.Button btnCadastroAdmin;
    }
}