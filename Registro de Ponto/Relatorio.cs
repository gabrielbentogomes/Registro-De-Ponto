﻿using System;
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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            mostrarNome();
        }

        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario();


        }
        private void btnRegistrarPonto_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            new Historico().Show();
            this.Hide();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            new Banco().Show();
            this.Hide();
        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            dataInicio.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }
    }
}