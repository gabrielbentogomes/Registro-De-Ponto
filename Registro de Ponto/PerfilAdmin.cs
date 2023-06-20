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
    public partial class PerfilAdmin : Form
    {
        public PerfilAdmin()
        {
            InitializeComponent();
            
        }

        private void btnControleJornada_Click(object sender, EventArgs e)
        {
            new Inicio_Admin().Show();
            this.Close();
        }

        private void alteraSenha_Click(object sender, EventArgs e)
        {
            new SenhaAdmin().Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
