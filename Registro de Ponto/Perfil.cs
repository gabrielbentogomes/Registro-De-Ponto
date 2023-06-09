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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            mostrarNome();
        }
        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario();

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnControleJornada_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Close();
        }

        private void adicionarFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Selecione a foto de perfil";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoFoto = openFileDialog.FileName;
                fotoPerfil.Image = Image.FromFile(caminhoFoto);
            }
        }
    }
}
