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
    public partial class TratarPonto : Form
    {
        public TratarPonto()
        {
            InitializeComponent();
        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            data.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataH.Text = data.Text;

            DateTime dataC = DateTime.Parse(data.Text);
            DayOfWeek diaSemana = dataC.DayOfWeek;

            string nomeDiaSemana = CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetDayName(diaSemana);

            diaSemanaH.Text = nomeDiaSemana;




        }

    }
}
