﻿using System;

namespace Registro_de_Ponto
{
    internal class Pessoa
    {
        private static string nome = string.Empty;
        private static string matricula = string.Empty;
        private static string senha = string.Empty;
        private static DateTime horaEntrada;
        private static DateTime horaSaida;
        private static string horaTotal = string.Empty;

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

        internal static DateTime HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }

        internal static DateTime HoraSaida
        {
            get { return horaSaida; }
            set { horaSaida = value; }
        }

        internal static string HoraTotal
        {
            get { return horaTotal; }
            set { horaTotal = value; }
        }
    }

}
