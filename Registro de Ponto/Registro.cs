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
using iText.StyledXmlParser.Jsoup.Nodes;

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

            DateTime dtaHora = DateTime.Now;

            // Obtendo as partes individuais
            string data = dtaHora.ToString("dd/MM/yyyy");
            string hora = dtaHora.ToString("HH:mm");

            // Exibindo a string no formulário ou onde for necessário
            dataHora.Text = data + "  " + hora;
            dataHora.ReadOnly = true;

        }
        private void mostrarNome()
        {
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            nomeUsuario.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome;

        }
        private void nomeUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            DateTime dtaHora = DateTime.Now;
            DateTime dt =  DateTime.Now.Date;
            FuncaoPegarUser f1 = new FuncaoPegarUser();
            // Obtendo as partes individuais
            string data = dt.ToString("dd/MM/yyyy");
            string hora = dtaHora.ToString("HH:mm");
            if (radioButton1.Checked)
            {
                try
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                    con.Open();

                    string insertQuery = "INSERT INTO Entrada VALUES (@Data, @MatriculaFunc, @HoraEntrada);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Data", data);
                        cmd.Parameters.AddWithValue("@MatriculaFunc", f1.BuscarInformacoesUsuario(matriculas.Matriculas).Matricula.ToString());
                        cmd.Parameters.AddWithValue("@HoraEntrada", hora);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrado com sucesso");
                    }

                    con.Close();
                }
                catch(Exception ex) {
                    MessageBox.Show("Ocorreu um erro durante o registro: " + ex.Message);
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!";
                    con.Open();

                    string insertQuery = "INSERT INTO Saida VALUES (@Data, @MatriculaFunc, @HoraSaida);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Data", data);
                        cmd.Parameters.AddWithValue("@MatriculaFunc", f1.BuscarInformacoesUsuario(matriculas.Matriculas).Matricula.ToString());
                        cmd.Parameters.AddWithValue("@HoraSaida", hora);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrado com sucesso");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante o registro: " + ex.Message);
                }
            }
            this.Close();
        }

        private void dataHora_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
