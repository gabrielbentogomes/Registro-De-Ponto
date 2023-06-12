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
    public partial class BancoAdmin : Form
    {
        public BancoAdmin()
        {
            InitializeComponent();
        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            dataInicio.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void solicitarBanco_Click(object sender, EventArgs e)
        {
                //PEGAR O DIA INICIAL E DIA FINAL
                string di = dataInicio.Text;
                string df = dataFinal.Text;

                new MostrarBancoAdmin(di, df).Show();
                this.Close(); 
        }
    }
}
