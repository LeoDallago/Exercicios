namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 13");

            Console.WriteLine("Por favor, informe a quantidade de PAES vendidos: ");
            string paes = Console.ReadLine();
            decimal paesQuantidade = Convert.ToDecimal(paes);

            Console.WriteLine("Por favor, informe a quantidade de BROAS vendidas : ");
            string broas = Console.ReadLine();
            decimal broasQuantidade = Convert.ToDecimal(broas);

            decimal paesValor = 0.12m;
            decimal broasValor = 1.50m;

            decimal arrecadacao = (paesQuantidade * paesValor) + (broasQuantidade * broasValor);

            decimal poupanca = 0.1m * arrecadacao;

            Console.WriteLine($"A ARRECADACAO foi de {arrecadacao} e a sua POUPANCA eh de {poupanca}");

            //Mantem o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}