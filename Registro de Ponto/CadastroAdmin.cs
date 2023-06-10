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
    public partial class CadastroAdmin : Form
    {
        public CadastroAdmin()
        {
            InitializeComponent();
        }

        private void mostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraSenha.Checked)
            {
                senhaCadastro.PasswordChar = '\0';
            }
            else
            {
                senhaCadastro.PasswordChar = '*';
            }
        }
    }
}
