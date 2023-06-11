using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Ponto
{
    internal class Administrador
    {
        private static string nome = string.Empty;
        private static string matricula = string.Empty;
        private static string senha = string.Empty;

        internal static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal static string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        internal static string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
