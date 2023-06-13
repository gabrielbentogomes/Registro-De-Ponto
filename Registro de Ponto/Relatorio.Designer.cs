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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.TextBox();
            this.dataFinal = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSelecionarPeriodo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.solicitarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // dataInicio
            // 
            this.dataInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataInicio.Location = new System.Drawing.Point(75, 16);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.Size = new System.Drawing.Size(100, 20);
            this.dataInicio.TabIndex = 2;
            // 
            // dataFinal
            // 
            this.dataFinal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataFinal.Location = new System.Drawing.Point(294, 16);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            this.dataFinal.Size = new System.Drawing.Size(100, 20);
            this.dataFinal.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(99, 71);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 4;
            // 
            // btnSelecionarPeriodo
            // 
            this.btnSelecionarPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.btnSelecionarPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarPeriodo.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarPeriodo.Location = new System.Drawing.Point(145, 257);
            this.btnSelecionarPeriodo.Name = "btnSelecionarPeriodo";
            this.btnSelecionarPeriodo.Size = new System.Drawing.Size(126, 36);
            this.btnSelecionarPeriodo.TabIndex = 5;
            this.btnSelecionarPeriodo.Text = "Selecionar período";
            this.btnSelecionarPeriodo.UseVisualStyleBackColor = false;
            this.btnSelecionarPeriodo.Click += new System.EventHandler(this.btnSelecionarPeriodo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário:";
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.nomeUsuario.Location = new System.Drawing.Point(66, 327);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.ReadOnly = true;
            this.nomeUsuario.Size = new System.Drawing.Size(328, 20);
            this.nomeUsuario.TabIndex = 7;
            // 
            // solicitarRelatorio
            // 
            this.solicitarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.solicitarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solicitarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solicitarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitarRelatorio.ForeColor = System.Drawing.Color.White;
            this.solicitarRelatorio.Location = new System.Drawing.Point(145, 381);
            this.solicitarRelatorio.Name = "solicitarRelatorio";
            this.solicitarRelatorio.Size = new System.Drawing.Size(126, 36);
            this.solicitarRelatorio.TabIndex = 8;
            this.solicitarRelatorio.Text = "Solicitar";
            this.solicitarRelatorio.UseVisualStyleBackColor = false;
            this.solicitarRelatorio.Click += new System.EventHandler(this.solicitarRelatorio_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.solicitarRelatorio);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarPeriodo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio e Espelho de ponto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataInicio;
        private System.Windows.Forms.TextBox dataFinal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSelecionarPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.Button solicitarRelatorio;
    }
}