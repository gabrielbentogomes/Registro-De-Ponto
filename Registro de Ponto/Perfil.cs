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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnControleJornada_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }
    }
}
