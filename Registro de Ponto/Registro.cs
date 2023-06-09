using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Registro_de_Ponto
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            ExibirDataAtual();
            mostrarNome();
        }

        private void ExibirDataAtual()
        {
            dataHora.Text = DateTime.Now.ToString();
            dataHora.ReadOnly = true;
        }
        private void mostrarNome()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "SELECT usuario FROM user_tb WHERE usuario = @Nome";
            cmd = new SqlCommand(login, con);
            cmd.Parameters.AddWithValue("@Nome", Pessoa.Nome.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nomeUsuario.Text = reader["usuario"].ToString();
            }

        }
        private void nomeUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horário salvo com sucesso!", "Mensagem", MessageBoxButtons.OK);            
            this.Close();
        }

    }


}
