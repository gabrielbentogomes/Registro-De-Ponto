namespace Registro_de_Ponto
{
    partial class Relatorio
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
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRegistrarPonto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControleJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnBanco);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnRegistrarPonto);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 198);
            this.panel1.TabIndex = 3;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.White;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnRelatorio.Location = new System.Drawing.Point(32, 96);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(165, 34);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatório espelho de ponto";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnBanco.ForeColor = System.Drawing.Color.White;
            this.btnBanco.Location = new System.Drawing.Point(32, 136);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(165, 34);
            this.btnBanco.TabIndex = 5;
            this.btnBanco.Text = "Banco de horas";
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(32, 56);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(165, 34);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Histórico de ponto";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRegistrarPonto
            // 
            this.btnRegistrarPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnRegistrarPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPonto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPonto.Location = new System.Drawing.Point(32, 16);
            this.btnRegistrarPonto.Name = "btnRegistrarPonto";
            this.btnRegistrarPonto.Size = new System.Drawing.Size(165, 34);
            this.btnRegistrarPonto.TabIndex = 3;
            this.btnRegistrarPonto.Text = "Registrar ponto";
            this.btnRegistrarPonto.UseVisualStyleBackColor = false;
            this.btnRegistrarPonto.Click += new System.EventHandler(this.btnRegistrarPonto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.perfilDoUsuárioToolStripMenuItem,
            this.btnControleJornada});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // perfilDoUsuárioToolStripMenuItem
            // 
            this.perfilDoUsuárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.perfilDoUsuárioToolStripMenuItem.Name = "perfilDoUsuárioToolStripMenuItem";
            this.perfilDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.perfilDoUsuárioToolStripMenuItem.Text = "Perfil do usuário";
            // 
            // btnControleJornada
            // 
            this.btnControleJornada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControleJornada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleJornada.Name = "btnControleJornada";
            this.btnControleJornada.Size = new System.Drawing.Size(143, 21);
            this.btnControleJornada.Text = "Controle de Jornada";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnRegistrarPonto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnControleJornada;
    }
}