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
using System.Runtime.InteropServices;

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

        public void loginEntrar_Click(object sender, EventArgs e)
        {
            
            if (radioFunc.Checked)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string login = "SELECT * FROM funcionario WHERE matricula='" + usuario.Text + "'and senha ='" + senha.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()==true)
                {
                    matriculas.Matriculas = usuario.Text;
                    new Inicio_Func().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(radioAdmin.Checked)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string login = "SELECT * FROM Administrador WHERE matricula='" + usuario.Text + "'and senha ='" + senha.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read()==true)
                {
                    Administrador.Matricula = usuario.Text;
                    new Inicio_Super().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        }
 }

