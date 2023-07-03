namespace Registro_de_Ponto
{
    partial class TratarPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TratarPonto));
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox224 = new System.Windows.Forms.TextBox();
            this.textBox233 = new System.Windows.Forms.TextBox();
            this.textBox239 = new System.Windows.Forms.TextBox();
            this.textBox240 = new System.Windows.Forms.TextBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.diaSemanaH = new System.Windows.Forms.Label();
            this.dataH = new System.Windows.Forms.Label();
            this.localizarFunc = new System.Windows.Forms.Button();
            this.alterarH = new System.Windows.Forms.Button();
            this.btnSelecionarPeriodo = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.nomeUsuario.Location = new System.Drawing.Point(205, 270);
            this.nomeUsuario.Multiline = true;
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(136, 20);
            this.nomeUsuario.TabIndex = 26;
            this.nomeUsuario.TextChanged += new System.EventHandler(this.nomeUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Digite a matrícula: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(17, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 21);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marcação 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(432, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Horas ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marcação 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(271, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Irregularidade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox224);
            this.panel1.Controls.Add(this.textBox233);
            this.panel1.Controls.Add(this.textBox239);
            this.panel1.Controls.Add(this.textBox240);
            this.panel1.Controls.Add(this.panel26);
            this.panel1.Location = new System.Drawing.Point(17, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 59);
            this.panel1.TabIndex = 23;
            // 
            // textBox224
            // 
            this.textBox224.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox224.Location = new System.Drawing.Point(425, 28);
            this.textBox224.Name = "textBox224";
            this.textBox224.ReadOnly = true;
            this.textBox224.Size = new System.Drawing.Size(57, 20);
            this.textBox224.TabIndex = 257;
            // 
            // textBox233
            // 
            this.textBox233.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox233.Location = new System.Drawing.Point(234, 28);
            this.textBox233.Name = "textBox233";
            this.textBox233.ReadOnly = true;
            this.textBox233.Size = new System.Drawing.Size(171, 20);
            this.textBox233.TabIndex = 253;
            // 
            // textBox239
            // 
            this.textBox239.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox239.Location = new System.Drawing.Point(128, 28);
            this.textBox239.Name = "textBox239";
            this.textBox239.Size = new System.Drawing.Size(85, 20);
            this.textBox239.TabIndex = 250;
            // 
            // textBox240
            // 
            this.textBox240.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox240.Location = new System.Drawing.Point(7, 28);
            this.textBox240.Name = "textBox240";
            this.textBox240.Size = new System.Drawing.Size(85, 20);
            this.textBox240.TabIndex = 249;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(249)))));
            this.panel26.Controls.Add(this.diaSemanaH);
            this.panel26.Controls.Add(this.dataH);
            this.panel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel26.ForeColor = System.Drawing.Color.White;
            this.panel26.Location = new System.Drawing.Point(1, 1);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(615, 21);
            this.panel26.TabIndex = 248;
            // 
            // diaSemanaH
            // 
            this.diaSemanaH.AutoSize = true;
            this.diaSemanaH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.diaSemanaH.Location = new System.Drawing.Point(107, 4);
            this.diaSemanaH.Name = "diaSemanaH";
            this.diaSemanaH.Size = new System.Drawing.Size(91, 13);
            this.diaSemanaH.TabIndex = 24;
            this.diaSemanaH.Text = "Dia da semana";
            // 
            // dataH
            // 
            this.dataH.AutoSize = true;
            this.dataH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.dataH.Location = new System.Drawing.Point(3, 4);
            this.dataH.Name = "dataH";
            this.dataH.Size = new System.Drawing.Size(34, 13);
            this.dataH.TabIndex = 23;
            this.dataH.Text = "Data";
            // 
            // localizarFunc
            // 
            this.localizarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.localizarFunc.Location = new System.Drawing.Point(347, 270);
            this.localizarFunc.Name = "localizarFunc";
            this.localizarFunc.Size = new System.Drawing.Size(75, 23);
            this.localizarFunc.TabIndex = 27;
            this.localizarFunc.Text = "Localizar";
            this.localizarFunc.UseVisualStyleBackColor = true;
            this.localizarFunc.Click += new System.EventHandler(this.localizarFunc_Click);
            // 
            // alterarH
            // 
            this.alterarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.alterarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alterarH.ForeColor = System.Drawing.Color.White;
            this.alterarH.Location = new System.Drawing.Point(211, 435);
            this.alterarH.Name = "alterarH";
            this.alterarH.Size = new System.Drawing.Size(130, 38);
            this.alterarH.TabIndex = 28;
            this.alterarH.Text = "Alterar";
            this.alterarH.UseVisualStyleBackColor = false;
            this.alterarH.Click += new System.EventHandler(this.alterarH_Click);
            // 
            // btnSelecionarPeriodo
            // 
            this.btnSelecionarPeriodo.Location = new System.Drawing.Point(194, 224);
            this.btnSelecionarPeriodo.Name = "btnSelecionarPeriodo";
            this.btnSelecionarPeriodo.Size = new System.Drawing.Size(126, 23);
            this.btnSelecionarPeriodo.TabIndex = 33;
            this.btnSelecionarPeriodo.Text = "Selecionar período";
            this.btnSelecionarPeriodo.UseVisualStyleBackColor = true;
            this.btnSelecionarPeriodo.Click += new System.EventHandler(this.btnSelecionarPeriodo_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(144, 50);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data: ";
            // 
            // data
            // 
            this.data.Cursor = System.Windows.Forms.Cursors.Default;
            this.data.Location = new System.Drawing.Point(220, 12);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 31;
            this.data.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // TratarPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 492);
            this.Controls.Add(this.btnSelecionarPeriodo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alterarH);
            this.Controls.Add(this.localizarFunc);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TratarPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratar Ponto";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox224;
        private System.Windows.Forms.TextBox textBox233;
        private System.Windows.Forms.TextBox textBox239;
        private System.Windows.Forms.TextBox textBox240;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label diaSemanaH;
        private System.Windows.Forms.Label dataH;
        private System.Windows.Forms.Button localizarFunc;
        private System.Windows.Forms.Button alterarH;
        private System.Windows.Forms.Button btnSelecionarPeriodo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox data;
    }
}