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
    public partial class Inicio_Admin : Form
    {
        public Inicio_Admin()
        {
            InitializeComponent();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            new BancoAdmin().Show();
        }

        private void btntratarPonto_Click(object sender, EventArgs e)
        {
            new TratarPonto().Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new CadastroFunc().Show();
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

        private void btnCadastroAdmin_Click(object sender, EventArgs e)
        {
            new CadastroAdmin().Show();
        }
    }
}
