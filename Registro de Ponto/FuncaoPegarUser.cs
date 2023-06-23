using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Ponto
{
    internal class FuncaoPegarUser
    {
        public Pessoa BuscarInformacoesUsuario(string matriculaa)
        {

            string nome = null;
            string matricula = null;
            string horaEntrada = null;
            string horaSaida = null;

            using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
            {
                con.Open();

                string login = "SELECT nomeCompleto, matricula, horarioEntrada, horarioSaida FROM Funcionario WHERE matricula = @Matricula";
                using (SqlCommand cmd = new SqlCommand(login, con))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matriculaa);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
    
                            nome = reader["nomeCompleto"].ToString();
                            matricula = reader["matricula"].ToString();
                            if (reader["horarioEntrada"] != DBNull.Value)
                            {
                                TimeSpan horaEntradaDb = (TimeSpan)reader["horarioEntrada"];
                                horaEntrada = horaEntradaDb.ToString();
                            }

                            if (reader["horarioSaida"] != DBNull.Value)
                            {
                                TimeSpan horaSaidaDb = (TimeSpan)reader["horarioSaida"];
                                horaSaida = horaSaidaDb.ToString();
                            }

                        }
                    }
                }
                
    
            }
            Pessoa pessoa = null;
            pessoa = new Pessoa(nome.ToString(), matricula.ToString(), horaEntrada.ToString(), horaSaida.ToString());
            return pessoa;
        }




    }
}
