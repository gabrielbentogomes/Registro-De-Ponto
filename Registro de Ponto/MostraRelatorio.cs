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
    public partial class MostraRelatorio : Form
    {
        public MostraRelatorio()
        {
            InitializeComponent();
            mostrarNome();
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
    }
}
