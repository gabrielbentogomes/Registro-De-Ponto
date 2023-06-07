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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
            ExibirDataAtual();
            ExibirDiaDaSemana();
        }


        private void ExibirDataAtual()
        {
            DateTime dataAtual = DateTime.Now;

            string dia = dataAtual.Day.ToString();
            string mes = dataAtual.Month.ToString();
            string ano = dataAtual.Year.ToString();

            string dataFormatada = $"{dia}/{mes}/{ano}";

            dataH.Text = dataFormatada;
        }

        private void ExibirDiaDaSemana()
        {
            DateTime dataAtual = DateTime.Now;

            // Obter o nome do dia da semana em português
            string diaSemana = CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetDayName(dataAtual.DayOfWeek);

            diaSemanaH.Text = diaSemana;
        }

    }
}
