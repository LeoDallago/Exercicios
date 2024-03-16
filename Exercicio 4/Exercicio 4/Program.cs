namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4");

            Console.WriteLine("Por favor, informe a quilometragem inicial:");
            string kmInicial = Console.ReadLine();
            decimal kmInicialValor = Convert.ToDecimal(kmInicial);

            Console.WriteLine("Por favor, informe a quilometragem final:");
            string kmFinal = Console.ReadLine();
            decimal kmFinallValor = Convert.ToDecimal(kmFinal);

            Console.WriteLine("Por favor, informe o consumo de combustivel:");
            string consumo = Console.ReadLine();
            decimal consumoValor = Convert.ToDecimal(consumo);

            decimal consumoFinal = kmInicialValor - kmFinallValor / consumoValor;


            Console.WriteLine($"O consumo eh: {consumoFinal}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
