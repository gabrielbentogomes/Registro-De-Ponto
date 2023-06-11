using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registro_de_Ponto
{
    public partial class MostraRelatorio : Form
    {

        private string ma;
        private string di;
        private string df;

        public MostraRelatorio(string ma, string di, string df)
        {
            InitializeComponent();
            mostrarNome();
            ExibirDataAtual();

            this.ma = ma;
            this.di = di;
            this.df = df;

            MostrarMesAno();
            MostrarDiaSemana();
            MostrarData();
        }
        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            lblNomeFunc.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome;
            lblMatricula.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Matricula;
            lblEntrada.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).HoraEntrada;
            lblSaida.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).HoraSaida;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ExibirDataAtual()
        {
            dataEmissao.Text = DateTime.Now.ToString();
        }

        private void MostrarMesAno()
        {
            mesAno.Text = ma;
        }

        private void MostrarDiaSemana()
        {
            DateTime dataInicio = DateTime.Parse(di);
            DateTime dataFinal = DateTime.Parse(df);

            int top = 250; // Posição vertical inicial das labels
            float tamanhoFonte = 10; // Tamanho da fonte desejado
            string familiaFonte = "Book Antiqua"; // Família de fonte desejada
            FontStyle estiloFonte = FontStyle.Bold; // Estilo de fonte desejado


            for (DateTime data = dataInicio; data <= dataFinal; data = data.AddDays(1))
            {
                string diaDaSemana = data.ToString("dddd", new CultureInfo("pt-BR"));

                Label label = new Label();
                label.Text = diaDaSemana;
                label.Top = top;
                label.Left = 10;
                label.AutoSize = true;
                label.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                panel1.Controls.Add(label);

                top += label.Height + 16; // Espaçamento entre as labels
            }
        }

        private void MostrarData()
        {
            DateTime dataInicio = DateTime.Parse(di);
            DateTime dataFinal = DateTime.Parse(df);

            int top = 250; // Posição vertical inicial das labels
            float tamanhoFonte = 10; // Tamanho da fonte desejado
            string familiaFonte = "Book Antiqua"; // Família de fonte desejada
            FontStyle estiloFonte = FontStyle.Bold; // Estilo de fonte desejado

            for (DateTime data = dataInicio; data <= dataFinal; data = data.AddDays(1))
            {
                string dataFormatada = data.ToString("dd/MM/yyyy"); // Formato desejado da data

                Label label = new Label();
                label.Text = dataFormatada;
                label.Top = top;
                label.Left = 129;
                label.AutoSize = true;
                label.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                panel1.Controls.Add(label);

                top += label.Height + 16; // Espaçamento entre as labels
            }

        }

        
    }
}
