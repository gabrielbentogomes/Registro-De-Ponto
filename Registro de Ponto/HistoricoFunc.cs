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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_de_Ponto
{
    public partial class HistoricoFunc : Form
    {
        public HistoricoFunc()
        {
            InitializeComponent();
            mostrarNome();
            mostrarDataeDia();
        }
        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome; ;
        }

        private void mostrarDataeDia()
        {
            dataH.Text = DateTime.Now.ToString("dd/MM/yyyy");

            CultureInfo cultura = new CultureInfo("pt-BR");
            diaSemanaH.Text = DateTime.Now.ToString("dddd", cultura);
        }
    }
}
