using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registro_de_Ponto
{
    public partial class MostraRelatorio : Form
    {

        private string ma;
        private string di;
        private string df;

        public MostraRelatorio(string ma, string di, string df)
        {
            InitializeComponent();
            mostrarNome();
            ExibirDataAtual();

            this.ma = ma;
            this.di = di;
            this.df = df;

            MostrarMesAno();
            MostrarDiaSemana();
            MostrarData();
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

        private void ExibirDataAtual()
        {
            dataEmissao.Text = DateTime.Now.ToString();
        }

        private void MostrarMesAno()
        {
            mesAno.Text = ma;
        }

        private void MostrarDiaSemana()
        {
            DateTime dataInicio = DateTime.Parse(di);
            DateTime dataFinal = DateTime.Parse(df);

            int top = 250; // Posição vertical inicial das labels
            float tamanhoFonte = 10; // Tamanho da fonte desejado
            string familiaFonte = "Book Antiqua"; // Família de fonte desejada
            FontStyle estiloFonte = FontStyle.Bold; // Estilo de fonte desejado


            for (DateTime data = dataInicio; data <= dataFinal; data = data.AddDays(1))
            {
                string diaDaSemana = data.ToString("dddd", new CultureInfo("pt-BR"));

                Label label = new Label();
                label.Text = diaDaSemana;
                label.Top = top;
                label.Left = 10;
                label.AutoSize = true;
                label.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                panel1.Controls.Add(label);

                top += label.Height + 16; // Espaçamento entre as labels
            }
        }

        private void MostrarData()
        {
            DateTime dataInicio = DateTime.Parse(di);
            DateTime dataFinal = DateTime.Parse(df);

            int top = 250; // Posição vertical inicial das labels
            float tamanhoFonte = 10; // Tamanho da fonte desejado
            string familiaFonte = "Book Antiqua"; // Família de fonte desejada
            FontStyle estiloFonte = FontStyle.Bold; // Estilo de fonte desejado

            for (DateTime data = dataInicio; data <= dataFinal; data = data.AddDays(1))
            {
                FuncaoPegarUser f1 = new FuncaoPegarUser();

                string matriculaa = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Matricula;
                string dataFormatada = data.ToString("dd/MM/yyyy");
                string horarioEntrada = null;
                string horarioSaida = null;

                using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
                {
                    con.Open();

                    string login = "SELECT f.matricula, f.nomeCompleto, COALESCE(e.horarioEntrada, NULL) AS horarioEntrada, COALESCE(s.horarioSaida, NULL) AS horarioSaida\r\nFROM Funcionario f\r\nLEFT JOIN (\r\n  SELECT matriculaFunc, horarioEntrada\r\n  FROM Entrada\r\n  WHERE dataDia = @dataFormatada\r\n) e ON f.matricula = e.matriculaFunc\r\nLEFT JOIN (\r\n  SELECT matriculaFunc, horarioSaida\r\n  FROM Saida\r\n  WHERE dataDia = @dataFormatadas\r\n) s ON f.matricula = s.matriculaFunc\r\nWHERE f.matricula = @Matricula;";
                    using (SqlCommand cmd = new SqlCommand(login, con))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", matriculaa);
                        cmd.Parameters.AddWithValue("@dataFormatada", dataFormatada);
                        cmd.Parameters.AddWithValue("@dataFormatadas", dataFormatada);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                horarioEntrada = reader["horarioEntrada"].ToString();
                                horarioSaida = reader["horarioSaida"].ToString();

                            }


                        }
                    }
                    con.Close();
                    con.Open();
                    login = "SELECT DATEDIFF(MINUTE, e.primeiroPontoEntrada, s.ultimoPontoSaida) AS HorasDecorridas\r\nFROM\r\n(\r\n  SELECT MIN(horarioEntrada) AS primeiroPontoEntrada\r\n  FROM Entrada\r\n  WHERE matriculaFunc = @Matricula\r\n    AND dataDia = @dataFormatada\r\n) AS e\r\nCROSS JOIN\r\n(\r\n  SELECT MAX(horarioSaida) AS ultimoPontoSaida\r\n  FROM Saida\r\n  WHERE matriculaFunc = @Matricula\r\n    AND dataDia = @dataFormatadas\r\n) AS s;\r\n";
                    using (SqlCommand cmd = new SqlCommand(login, con))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", matriculaa);
                        cmd.Parameters.AddWithValue("@dataFormatada", dataFormatada);
                        cmd.Parameters.AddWithValue("@dataFormatadas", dataFormatada);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    int minutosPassadosInt = reader.GetInt32(0);
                                    int horasDecorridas = minutosPassadosInt / 60;
                                    int minutosRestantes = minutosPassadosInt % 60;
                                    string tempoDecorrido = horasDecorridas.ToString("00") + ":" + minutosRestantes.ToString("00");

                                    Label lbl4 = new Label();
                                    lbl4.Text = tempoDecorrido;
                                    lbl4.Top = top;
                                    lbl4.Left = 655;
                                    lbl4.AutoSize = true;
                                    lbl4.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);
                                    panel1.Controls.Add(lbl4);
                                }
                                else
                                {
                                    Label lbl3 = new Label();
                                    lbl3.Text = "Falta";
                                    lbl3.Top = top;
                                    lbl3.Left = 500;
                                    lbl3.AutoSize = true;
                                    lbl3.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);
                                    panel1.Controls.Add(lbl3);

                                }
                            }

                            else
                            {
                                Label lbl3 = new Label();
                                lbl3.Text = "Falta";
                                lbl3.Top = top;
                                lbl3.Left = 335;
                                lbl3.AutoSize = true;
                                lbl3.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);
                                panel1.Controls.Add(lbl3);
                            }

                        }
                    }
                    con.Close();
                    con.Open();
                    
                    // Formato desejado da data
                    Label label = new Label();
                    Label lblEntrada = new Label();
                    Label lblSaida = new Label();

                    label.Text = dataFormatada;
                    lblEntrada.Text = horarioEntrada;
                    lblSaida.Text = horarioSaida;

                    label.Top = top;
                    label.Left = 129;
                    label.AutoSize = true;
                    label.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                    lblEntrada.Top = top;
                    lblEntrada.Left = 235;
                    lblEntrada.AutoSize = true;
                    lblEntrada.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                    lblSaida.Top = top;
                    lblSaida.Left = 335;
                    lblSaida.AutoSize = true;
                    lblSaida.Font = new Font(familiaFonte, tamanhoFonte, estiloFonte);

                    panel1.Controls.Add(label);
                    panel1.Controls.Add(lblEntrada);
                    panel1.Controls.Add(lblSaida);

                    top += label.Height + 16;
                    // Espaçamento entre as labels
                }
            }

        }

        private void calculaHora()
        {

        }
    }
}
