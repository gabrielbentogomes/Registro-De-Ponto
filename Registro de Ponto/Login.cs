using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Ponto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void mostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraSenha.Checked)
            {
                senha.PasswordChar = '\0';
            }
            else
            {
                senha.PasswordChar = '*';
            }
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }

        private void loginEntrar_Click(object sender, EventArgs e)
        {
            if (radioFunc.Checked)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string login = "SELECT * FROM user_tb WHERE usuario='" + usuario.Text + "'and senha ='" + senha.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()==true)
                {
                    new Inicio().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(radioSuper.Checked)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string login = "SELECT * FROM super_tb WHERE usuario='" + usuario.Text + "'and senha ='" + senha.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read()==true)
                {
                    new Inicio().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void radioFunc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioSuper_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
