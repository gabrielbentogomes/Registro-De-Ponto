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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controleDeJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarPontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDePontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioEspelhoDoPontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.perfilDoUsuárioToolStripMenuItem,
            this.controleDeJornadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controleDeJornadaToolStripMenuItem
            // 
            this.controleDeJornadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPontoToolStripMenuItem,
            this.históricoDePontoToolStripMenuItem,
            this.relatórioEspelhoDoPontoToolStripMenuItem,
            this.bancoDeHorasToolStripMenuItem});
            this.controleDeJornadaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleDeJornadaToolStripMenuItem.Name = "controleDeJornadaToolStripMenuItem";
            this.controleDeJornadaToolStripMenuItem.Size = new System.Drawing.Size(143, 21);
            this.controleDeJornadaToolStripMenuItem.Text = "Controle de Jornada";
            // 
            // perfilDoUsuárioToolStripMenuItem
            // 
            this.perfilDoUsuárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.perfilDoUsuárioToolStripMenuItem.Name = "perfilDoUsuárioToolStripMenuItem";
            this.perfilDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.perfilDoUsuárioToolStripMenuItem.Text = "Perfil do usuário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // registrarPontoToolStripMenuItem
            // 
            this.registrarPontoToolStripMenuItem.Name = "registrarPontoToolStripMenuItem";
            this.registrarPontoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.registrarPontoToolStripMenuItem.Text = "Registrar ponto";
            // 
            // históricoDePontoToolStripMenuItem
            // 
            this.históricoDePontoToolStripMenuItem.Name = "históricoDePontoToolStripMenuItem";
            this.históricoDePontoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.históricoDePontoToolStripMenuItem.Text = "Histórico de ponto";
            // 
            // relatórioEspelhoDoPontoToolStripMenuItem
            // 
            this.relatórioEspelhoDoPontoToolStripMenuItem.Name = "relatórioEspelhoDoPontoToolStripMenuItem";
            this.relatórioEspelhoDoPontoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.relatórioEspelhoDoPontoToolStripMenuItem.Text = "Relatório espelho do ponto";
            // 
            // bancoDeHorasToolStripMenuItem
            // 
            this.bancoDeHorasToolStripMenuItem.Name = "bancoDeHorasToolStripMenuItem";
            this.bancoDeHorasToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.bancoDeHorasToolStripMenuItem.Text = "Banco de horas";
            // 
            // Início
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Início";
            this.Text = "Início";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDePontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioEspelhoDoPontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}