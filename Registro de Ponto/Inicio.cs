using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Registro_de_Ponto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            new Historico().Show();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            new Banco().Show(); 
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            new Perfil().Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnRegistrarPonto_Click(object sender, EventArgs e)
        {
            new Registro().Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new Relatorio().Show();
        }
    }
}
