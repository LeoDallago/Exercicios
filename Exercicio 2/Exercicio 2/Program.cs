namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2 (ou exercicio 6 me confundi :)");

            #region ENTRADA DE DADOS

            Console.WriteLine("Por favor, informe a temperatura em celsius:");
            string temperatura = Console.ReadLine();
            decimal temperaturaValor = Convert.ToDecimal(temperatura);

            #endregion

            #region CONVERSAO E SAIDA

            decimal convercao = 0;

            convercao = temperaturaValor * 9 / 5 + 32;

            Console.WriteLine($"a temperatura em fahrenheit eh: {convercao}");

            #endregion

            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
