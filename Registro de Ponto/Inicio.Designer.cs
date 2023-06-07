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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControleJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRegistrarPonto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.dataHora = new System.Windows.Forms.TextBox();
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnRegistrarPonto);
            this.panel1.Location = new System.Drawing.Point(23, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 198);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(32, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Relatório espelho de ponto";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(32, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Banco de horas";
            this.button3.UseVisualStyleBackColor = false;
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
            this.btnRegistrarPonto.BackColor = System.Drawing.Color.White;
            this.btnRegistrarPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnRegistrarPonto.Location = new System.Drawing.Point(32, 16);
            this.btnRegistrarPonto.Name = "btnRegistrarPonto";
            this.btnRegistrarPonto.Size = new System.Drawing.Size(165, 34);
            this.btnRegistrarPonto.TabIndex = 3;
            this.btnRegistrarPonto.Text = "Registrar ponto";
            this.btnRegistrarPonto.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.dataHora);
            this.panel2.Controls.Add(this.nomeUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(342, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 198);
            this.panel2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(115, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "REGISTRAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataHora
            // 
            this.dataHora.Location = new System.Drawing.Point(169, 108);
            this.dataHora.Multiline = true;
            this.dataHora.Name = "dataHora";
            this.dataHora.Size = new System.Drawing.Size(139, 24);
            this.dataHora.TabIndex = 8;
            this.dataHora.TextChanged += new System.EventHandler(this.dataHora_TextChanged);
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Location = new System.Drawing.Point(77, 50);
            this.nomeUsuario.Multiline = true;
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(301, 24);
            this.nomeUsuario.TabIndex = 7;
            this.nomeUsuario.TextChanged += new System.EventHandler(this.nomeUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data e hora: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 28);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGISTRAR PONTO";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Inicio";
            this.Text = "Registrar_ponto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnControleJornada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarPonto;
        private System.Windows.Forms.TextBox dataHora;
        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}