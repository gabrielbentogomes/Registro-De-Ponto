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
    public partial class TratarPonto : Form
    {
        public TratarPonto()
        {
            InitializeComponent();
            localizarFunc.Enabled = false;
        }

        private void btnSelecionarPeriodo_Click(object sender, EventArgs e)
        {
            data.Text = monthCalendar1.SelectionStart.ToShortDateString();
            dataH.Text = data.Text;

            DateTime dataC = DateTime.Parse(data.Text);
            DayOfWeek diaSemana = dataC.DayOfWeek;

            string nomeDiaSemana = CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetDayName(diaSemana);

            diaSemanaH.Text = nomeDiaSemana;

            localizarFunc.Enabled = true;


        }

        private void localizarFunc_Click(object sender, EventArgs e)
        {
            string matricula = nomeUsuario.Text;
            string dataFormatada = dataH.Text;
            string horarioEntrada = null;
            string horarioSaida = null;

            using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
            {
                con.Open();

                string query = "SELECT f.matricula, f.nomeCompleto, e.horarioEntrada, s.horarioSaida " +
                               "FROM Funcionario f " +
                               "LEFT JOIN Entrada e ON f.matricula = e.matriculaFunc AND e.dataDia = @dataFormatada " +
                               "LEFT JOIN Saida s ON f.matricula = s.matriculaFunc AND s.dataDia = @dataFormatada " +
                               "WHERE f.matricula = @Matricula";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    cmd.Parameters.AddWithValue("@dataFormatada", dataFormatada);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            horarioEntrada = reader["horarioEntrada"].ToString();
                            horarioSaida = reader["horarioSaida"].ToString();
                        }
                    }
                }
                textBox240.Text = horarioEntrada;
                textBox239.Text = horarioSaida;
                con.Close();
                con.Open();
                query = "SELECT DATEDIFF(MINUTE, e.primeiroPontoEntrada, s.ultimoPontoSaida) AS HorasDecorridas\r\nFROM\r\n(\r\n  SELECT MIN(horarioEntrada) AS primeiroPontoEntrada\r\n  FROM Entrada\r\n  WHERE matriculaFunc = @Matricula\r\n    AND dataDia = @dataFormatada\r\n) AS e\r\nCROSS JOIN\r\n(\r\n  SELECT MAX(horarioSaida) AS ultimoPontoSaida\r\n  FROM Saida\r\n  WHERE matriculaFunc = @Matricula\r\n    AND dataDia = @dataFormatadas\r\n) AS s;\r\n";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DateTime data = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
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
                                textBox224.Text = horasDecorridas.ToString("00") + ":" + minutosRestantes.ToString("00");
                            }
                            else
                            {
                                textBox224.Text = "";
                            }
                        }
                        else
                        {
                            textBox224.Text = "00:00";
                        }
                    }

                }
            }


        }

        private void alterarH_Click(object sender, EventArgs e)
        {
            string matricula = nomeUsuario.Text;
            string dataFormatada = dataH.Text;
            string horarioEntrada = textBox240.Text;
            string horarioSaida = textBox239.Text;

            using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
            {
                con.Open();
                
                // Atualizar o horário de entrada
                string updateEntrada = "UPDATE Entrada SET horarioEntrada = @HorarioEntrada WHERE matriculaFunc = @Matricula AND dataDia = @DataFormatada";
                using (SqlCommand cmdEntrada = new SqlCommand(updateEntrada, con))
                {
                    cmdEntrada.Parameters.AddWithValue("@HorarioEntrada", horarioEntrada);
                    cmdEntrada.Parameters.AddWithValue("@Matricula", matricula);
                    cmdEntrada.Parameters.AddWithValue("@DataFormatada", dataFormatada);

                    int rowsAffected = cmdEntrada.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Atualização da entrada realizada com sucesso
                        MessageBox.Show("Horário de entrada atualizado com sucesso!");
                    }
                    else
                    {
                        string insereEntrada = "INSERT INTO Entrada (dataDia, matriculaFunc, horarioEntrada) VALUES (@DataFormatada, @Matricula, @HorarioEntrada)";
                        using (SqlCommand cmdInsere = new SqlCommand(insereEntrada, con))
                        {
                            cmdInsere.Parameters.AddWithValue("@DataFormatada", dataFormatada);
                            cmdInsere.Parameters.AddWithValue("@Matricula", matricula);
                            cmdInsere.Parameters.AddWithValue("@HorarioEntrada", horarioEntrada);

                            int rowsAffectedd = cmdInsere.ExecuteNonQuery();
                            if (rowsAffectedd > 0)
                            {
                                // Inserção da saída realizada com sucesso
                                MessageBox.Show("Horário de entrada inserido com sucesso!");
                            }
                        }
                    }
                }

                // Atualizar o horário de saída
                string updateSaida = "UPDATE Saida SET horarioSaida = @HorarioSaida WHERE matriculaFunc = @Matricula AND dataDia = @DataFormatada";
                using (SqlCommand cmdSaida = new SqlCommand(updateSaida, con))
                {
                    cmdSaida.Parameters.AddWithValue("@HorarioSaida", horarioSaida);
                    cmdSaida.Parameters.AddWithValue("@Matricula", matricula);
                    cmdSaida.Parameters.AddWithValue("@DataFormatada", dataFormatada);

                    int rowsAffected = cmdSaida.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Atualização da saída realizada com sucesso
                        MessageBox.Show("Horário de saída atualizado com sucesso!");
                    }
                    else
                    {
                        string insereSaida = "INSERT INTO Saida (dataDia, matriculaFunc, horarioSaida) VALUES (@DataFormatada, @Matricula, @HorarioSaida)";
                        using (SqlCommand cmdInsere = new SqlCommand(insereSaida, con))
                        {
                            cmdInsere.Parameters.AddWithValue("@DataFormatada", dataFormatada);
                            cmdInsere.Parameters.AddWithValue("@Matricula", matricula);
                            cmdInsere.Parameters.AddWithValue("@HorarioSaida", horarioSaida);

                            int rowsAffectedd = cmdInsere.ExecuteNonQuery();
                            if (rowsAffectedd > 0)
                            {
                                // Inserção da saída realizada com sucesso
                                MessageBox.Show("Horário de saída inserido com sucesso!");
                            }
                        }

                    }
                }
            }
        }
    }
}

