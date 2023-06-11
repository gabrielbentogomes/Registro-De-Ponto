using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Ponto
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            mostrarNome();
        }

        //VARIÁVEIS
        private string mes;
        private string ano;

        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome;


        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            dataInicio.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void solicitarRelatorio_Click(object sender, EventArgs e)
        {

            //PEGAR O MÊS E ANO
            DateTime dataI = DateTime.Parse(dataInicio.Text);
            DateTime dataF = DateTime.Parse(dataFinal.Text);

            mes = dataI.ToString("MMMM");
            ano = dataF.ToString("yyyy");

            string ma = mes.ToUpper() + " / " + ano;

            //PEGAR O DIA INICIAL E DIA FINAL
            string di = dataInicio.Text;
            string df = dataFinal.Text;

            new MostraRelatorio(ma, di, df).Show();
            this.Close();
        }
    }
}
