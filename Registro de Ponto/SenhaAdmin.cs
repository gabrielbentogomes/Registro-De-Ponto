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
    public partial class SenhaAdmin : Form
    {
        public SenhaAdmin()
        {
            InitializeComponent();
        }

        private void cancelarSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (mostraSenha.Checked)
            {
                novaSenha.PasswordChar = '\0';
                cNovaSenha.PasswordChar = '\0';
            }
            else
            {
                novaSenha.PasswordChar = '*';
                cNovaSenha.PasswordChar = '*';
            }
        }

        private void confirmaSenha_Click(object sender, EventArgs e)
        {
            FuncaoPegarAdmin fa = new FuncaoPegarAdmin();
            string matricula = fa.BuscarInformacoesAdmin(matriculas.Matriculas).Matricula;
            string senhaNOva = novaSenha.Text;
            if (novaSenha.Text == cNovaSenha.Text)
            {
                using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
                {
                    con.Open();

                    string login = "UPDATE Admin SET senha = @SenhaNova WHERE matricula = @Matricula;";
                    using (SqlCommand cmd = new SqlCommand(login, con))
                    {
                        cmd.Parameters.AddWithValue("@SenhaNova", senhaNOva);
                        cmd.Parameters.AddWithValue("@Matricula", matricula);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Senha alterada com sucesso!", "Mensagem", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("As senhas não combinam!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
