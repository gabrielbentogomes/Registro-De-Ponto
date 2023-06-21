using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Ponto
{
    internal class Administrador
    {
        private string nome = string.Empty;
        private string matricula = string.Empty;
        private string senha = string.Empty;

        internal string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        internal string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public Administrador(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }
    }
}
