using System;

namespace Registro_de_Ponto
{
    internal class Pessoa
    {
        private string nome;
        private string matricula;
        private string senha;
        private string horaEntrada;
        private string horaSaida;
        private string horaTotal;

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

        internal string HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }

        internal string HoraSaida
        {
            get { return horaSaida; }
            set { horaSaida = value; }
        }

        internal string HoraTotal
        {
            get { return horaTotal; }
            set { horaTotal = value; }
        }

        // Construtor da classe
        public Pessoa(string nome, string matricula, string horaEntrada, string horaSaida)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.horaEntrada = horaEntrada;
            this.horaSaida = horaSaida;
        }
    }
}
