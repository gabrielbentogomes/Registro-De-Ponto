using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Ponto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            ExibirDataAtual();
        }

        private void ExibirDataAtual()
        {
            dataHora.Text = DateTime.Now.ToString();
            dataHora.ReadOnly = true;
        }

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {
            /*GABRIEL, AQUI VOCÊ TEM QUE PEGAR DO BD O NOME COMPLETO DO USUÁRIO*/
            nomeUsuario.ReadOnly = true;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            new Historico().Show();
            this.Hide();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            new Banco().Show(); 
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            new Perfil().Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
