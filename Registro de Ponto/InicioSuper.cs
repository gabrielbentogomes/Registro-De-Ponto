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
    public partial class Inicio_Super : Form
    {
        public Inicio_Super()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new Relatorio().Show();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            new Banco().Show();
        }

        private void btntratarPonto_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
        }
    }
}
