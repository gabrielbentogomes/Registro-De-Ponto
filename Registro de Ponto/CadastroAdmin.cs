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
    public partial class CadastroAdmin : Form
    {
        public CadastroAdmin()
        {
            InitializeComponent();
        }

        private void mostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraSenha.Checked)
            {
                senhaCadastro.PasswordChar = '\0';
            }
            else
            {
                senhaCadastro.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                con.Open();

                string insertQuery = "INSERT INTO Admin VALUES (@Nome, @Matricula, @Senha)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeCadastro.Text);
                    cmd.Parameters.AddWithValue("@Matricula", matriculaCadastro.Text);
                    cmd.Parameters.AddWithValue("@Senha", senhaCadastro.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o cadastro: " + ex.Message);
            }
        }
    }
}
