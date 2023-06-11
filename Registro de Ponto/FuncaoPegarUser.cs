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
        public string BuscarInformacoesUsuario()
        {
            string nome = null;

            using (SqlConnection con = new SqlConnection("Data Source=gabriel261020.database.windows.net;Initial Catalog=Registro_Ponto;User ID=gabrielbento;Password=BDlg@#$!"))
            {
                con.Open();

                string login = "SELECT nome FROM funcionario WHERE matricula = @Matricula";
                using (SqlCommand cmd = new SqlCommand(login, con))
                {
                    cmd.Parameters.AddWithValue("@Matricula", Pessoa.Matricula);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nome = reader["nome"].ToString();
                        }
                    }
                }
            }

            return nome;
        }


    }
}
