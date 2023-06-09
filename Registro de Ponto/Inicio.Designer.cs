namespace Registro_de_Ponto
{
    partial class Inicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRegistrarPonto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnBanco);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnRegistrarPonto);
            this.panel1.Location = new System.Drawing.Point(205, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 198);
            this.panel1.TabIndex = 2;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(32, 96);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(294, 34);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatório espelho de ponto";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.ForeColor = System.Drawing.Color.White;
            this.btnBanco.Location = new System.Drawing.Point(32, 136);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(294, 34);
            this.btnBanco.TabIndex = 5;
            this.btnBanco.Text = "Banco de horas";
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(32, 56);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(294, 34);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Histórico de ponto";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRegistrarPonto
            // 
            this.btnRegistrarPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnRegistrarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegistrarPonto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPonto.Location = new System.Drawing.Point(32, 16);
            this.btnRegistrarPonto.Name = "btnRegistrarPonto";
            this.btnRegistrarPonto.Size = new System.Drawing.Size(294, 34);
            this.btnRegistrarPonto.TabIndex = 3;
            this.btnRegistrarPonto.Text = "Registrar ponto";
            this.btnRegistrarPonto.UseVisualStyleBackColor = false;
            this.btnRegistrarPonto.Click += new System.EventHandler(this.btnRegistrarPonto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem-Vindo(a) a página inicial!";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnControleJornada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnRegistrarPonto;
        private System.Windows.Forms.Label label1;
    }
}