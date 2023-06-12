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
    public partial class BancoFunc : Form
    {
        public BancoFunc()
        {
            InitializeComponent();
            mostrarNome();
        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            dataInicio.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome;


        }

        private void solicitarBanco_Click(object sender, EventArgs e)
        {
            //PEGAR O DIA INICIAL E DIA FINAL
            string di = dataInicio.Text;
            string df = dataFinal.Text;

            new MostraBancoFunc(di, df).Show();
            this.Close();
        }
    }
}
