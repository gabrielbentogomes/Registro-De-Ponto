using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Ponto
{
    internal class matriculas
    {
        private string matricula;

        public static string Matriculas { get; internal set; }

        internal string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    }
}
