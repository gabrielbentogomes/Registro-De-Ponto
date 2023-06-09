namespace Registro_de_Ponto
{
    internal class Pessoa
    {
        private static string nome = string.Empty;

        internal static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
