using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Registro_de_Ponto
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            ExibirDataAtual();
            mostrarNome();
        }

        private void ExibirDataAtual()
        {
            dataHora.Text = DateTime.Now.ToString();
            dataHora.ReadOnly = true;
        }
        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario();


        }
        private void nomeUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horário salvo com sucesso!", "Mensagem", MessageBoxButtons.OK);            
            this.Close();
        }

    }


}
