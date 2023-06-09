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

                string login = "SELECT usuario FROM user_tb WHERE usuario = @Nome";
                using (SqlCommand cmd = new SqlCommand(login, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", Pessoa.Nome);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nome = reader["usuario"].ToString();
                        }
                    }
                }
            }

            return nome;
        }


    }
}
