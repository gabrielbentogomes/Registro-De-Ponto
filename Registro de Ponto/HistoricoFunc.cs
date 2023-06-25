using iText.StyledXmlParser.Jsoup.Nodes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_de_Ponto
{
    public partial class HistoricoFunc : Form
    {
        FuncaoPegarUser f1 = new FuncaoPegarUser();
        public HistoricoFunc()
        {
            InitializeComponent();
            mostrarNome();
            mostrarDataeDia();
            carregarDados(f1.BuscarInformacoesUsuario(matriculas.Matriculas).Matricula);
        }
        private void mostrarNome()
        {
            nomeUsuario.Text = f1.BuscarInformacoesUsuario(matriculas.Matriculas).Nome; ;
        }

        private void mostrarDataeDia()
        {
            dataH.Text = DateTime.Now.ToString("dd/MM/yyyy");

            CultureInfo cultura = new CultureInfo("pt-BR");
            diaSemanaH.Text = DateTime.Now.ToString("dddd", cultura);
        }

        private void carregarDados(string matriculaa)
        {
            string minutosPassados = null;
            string horarioEntrada = null;
            string horarioSaida = null;
            using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
            {
                con.Open();

                string login = "SELECT f.matricula, f.nomeCompleto, COALESCE(e.horarioEntrada, NULL) AS horarioEntrada, COALESCE(s.horarioSaida, NULL) AS horarioSaida\r\nFROM Funcionario f\r\nLEFT JOIN (\r\n  SELECT matriculaFunc, horarioEntrada\r\n  FROM Entrada\r\n  WHERE CONVERT(DATE, dataDia, 103) = CONVERT(DATE, GETDATE())\r\n) e ON f.matricula = e.matriculaFunc\r\nLEFT JOIN (\r\n  SELECT matriculaFunc, horarioSaida\r\n  FROM Saida\r\n  WHERE CONVERT(DATE, dataDia, 103) = CONVERT(DATE, GETDATE())\r\n) s ON f.matricula = s.matriculaFunc\r\nWHERE f.matricula = @Matricula;\r\n";
                using (SqlCommand cmd = new SqlCommand(login, con))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matriculaa);

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
                login = "SELECT DATEDIFF(MINUTE, e.primeiroPontoEntrada, s.ultimoPontoSaida) AS HorasDecorridas\r\nFROM\r\n(\r\n  SELECT MIN(horarioEntrada) AS primeiroPontoEntrada\r\n  FROM Entrada\r\n  WHERE matriculaFunc = @Matricula\r\n    AND CONVERT(DATE, dataDia, 103) = CONVERT(DATE, GETDATE())\r\n) AS e\r\nCROSS JOIN\r\n(\r\n  SELECT MAX(horarioSaida) AS ultimoPontoSaida\r\n  FROM Saida\r\n  WHERE matriculaFunc = @Matricula\r\n    AND CONVERT(DATE, dataDia, 103) = CONVERT(DATE, GETDATE())\r\n) AS s;";
                using (SqlCommand cmd = new SqlCommand(login, con))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matriculaa);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                int minutosPassadosInt = reader.GetInt32(0);
                                int horasDecorridas = minutosPassadosInt / 60;
                                int minutosRestantes = minutosPassadosInt % 60;
                                txtTempoDecorrido.Text = horasDecorridas.ToString("00") + ":" + minutosRestantes.ToString("00");
                            }
                            else
                            {
                                txtTempoDecorrido.Text = "";
                            }
                        }
                        else
                        {
                            txtTempoDecorrido.Text = "00:00";
                        }
                    }
                    
                }

                
                txtEntrada.Text = horarioEntrada;
                txtSaida.Text = horarioSaida;
               
            }

        }

    }
}

