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
    public partial class MostrarBancoAdmin : Form
    {
        private string di;
        private string df;

        public MostrarBancoAdmin(string di, string df)
        {
            InitializeComponent();
            this.di = di;
            this.df = df;

            MostraPeriodo();
            MostrarData();
        }

        private void MostraPeriodo()
        {
            periodo.Text = di + " a " + df;
        }

        private void MostrarData()
        {
            DateTime dataInicio = DateTime.Parse(di);
            DateTime dataFinal = DateTime.Parse(df);

            int top = 40; // Posição vertical inicial das labels
            float tamanhoFonte = 10; // Tamanho da fonte desejado
            string familiaFonte = "Book Antiqua"; // Família de fonte desejada
            FontStyle estiloFonte = FontStyle.Bold; // Estilo de fonte desejado

            for (DateTime data = dataInicio; data <= dataFinal; data = data.AddDays(1))
            {
                string dataFormatada = data.ToString("dd/MM/yyyy"); // Formato desejado da data

                Label label = new Label();
                label.Text = dataFormatada;
                label.Top = top;
                label.Left = 0;
                label.AutoSize = true;
                label.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                panelHoras.Controls.Add(label);

                top += label.Height + 16; // Espaçamento entre as labels
            }

        }

    }
}
