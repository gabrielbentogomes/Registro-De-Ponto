using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Ponto
{
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                con.Open();

                string insertQuery = "INSERT INTO funcionario (Nome, Matricula, Senha, HoraEntrada, HoraSaida, HoraTotal) VALUES (@Nome, @Matricula, @Senha, @HoraEntrada, @HoraSaida, @HoraTotal)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome.Text);
                    cmd.Parameters.AddWithValue("@Matricula", matriculaa.Text);
                    cmd.Parameters.AddWithValue("@Senha", senha.Text);
                    cmd.Parameters.AddWithValue("@HoraEntrada", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@HoraSaida", maskedTextBox2.Text);
                    cmd.Parameters.AddWithValue("@HoraTotal", cargaHoraria.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso");
                }

                con.Close();
            }
            catch(Exception ex) { 
                MessageBox.Show("Ocorreu um erro durante o cadastro: " + ex.Message);
            }
        }

    }
}
