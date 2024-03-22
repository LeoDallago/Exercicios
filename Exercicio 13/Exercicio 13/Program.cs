namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 13");

            Console.WriteLine("Por favor, informe a quantidade de PAES vendidos: ");
            decimal paesQuantidade = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Por favor, informe a quantidade de BROAS vendidas : ");
            decimal broasQuantidade = Convert.ToDecimal(Console.ReadLine());


            CalculoArrecadacao(paesQuantidade,broasQuantidade);

            //Mantem o programa aberto (nao apagar)
            Console.ReadLine();
        }

        static void CalculoArrecadacao(decimal paesQuantidade, decimal broasQuantidade){

            decimal paesValor = 0.12m;
            decimal broasValor = 1.50m;

            decimal arrecadacao = (paesQuantidade * paesValor) + (broasQuantidade * broasValor);

            decimal poupanca = 0.1m * arrecadacao;

            Console.WriteLine($"A ARRECADACAO foi de {arrecadacao} e a sua POUPANCA eh de {poupanca}");

        }
    }
}