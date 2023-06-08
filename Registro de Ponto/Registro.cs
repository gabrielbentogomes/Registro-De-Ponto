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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            ExibirDataAtual();
        }

        private void ExibirDataAtual()
        {
            dataHora.Text = DateTime.Now.ToString();
            dataHora.ReadOnly = true;
        }

        private void nomeUsuario_TextChanged_1(object sender, EventArgs e)
        {
            /*GABRIEL, AQUI VOCÊ TEM QUE PEGAR DO BD O NOME COMPLETO DO USUÁRIO*/
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horário salvo com sucesso!", "Mensagem", MessageBoxButtons.OK);            
            this.Close();
        }

    }
}
