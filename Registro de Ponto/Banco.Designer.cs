namespace Registro_de_Ponto
{
    partial class Banco
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
            this.solicitarBanco = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.btnSelecionarPeriodo = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataFinal = new System.Windows.Forms.TextBox();
            this.dataInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solicitarBanco
            // 
            this.solicitarBanco.Location = new System.Drawing.Point(149, 396);
            this.solicitarBanco.Name = "solicitarBanco";
            this.solicitarBanco.Size = new System.Drawing.Size(126, 23);
            this.solicitarBanco.TabIndex = 15;
            this.solicitarBanco.Text = "Solicitar";
            this.solicitarBanco.UseVisualStyleBackColor = true;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(70, 342);
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Size = new System.Drawing.Size(328, 20);
            this.nome.TabIndex = 14;
            // 
            // btnSelecionarPeriodo
            // 
            this.btnSelecionarPeriodo.Location = new System.Drawing.Point(149, 272);
            this.btnSelecionarPeriodo.Name = "btnSelecionarPeriodo";
            this.btnSelecionarPeriodo.Size = new System.Drawing.Size(126, 23);
            this.btnSelecionarPeriodo.TabIndex = 13;
            this.btnSelecionarPeriodo.Text = "Selecionar período";
            this.btnSelecionarPeriodo.UseVisualStyleBackColor = true;
            this.btnSelecionarPeriodo.Click += new System.EventHandler(this.btnSelecionarPeriodo_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(103, 86);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 12;
            // 
            // dataFinal
            // 
            this.dataFinal.Location = new System.Drawing.Point(298, 31);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            this.dataFinal.Size = new System.Drawing.Size(100, 20);
            this.dataFinal.TabIndex = 11;
            // 
            // dataInicio
            // 
            this.dataInicio.Location = new System.Drawing.Point(79, 31);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.Size = new System.Drawing.Size(100, 20);
            this.dataInicio.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solicitarBanco);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.btnSelecionarPeriodo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.label2);
            this.Name = "Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de horas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solicitarBanco;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button btnSelecionarPeriodo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox dataFinal;
        private System.Windows.Forms.TextBox dataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}