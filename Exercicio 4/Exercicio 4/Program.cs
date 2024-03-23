namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4");

            Console.WriteLine("Por favor, informe a quilometragem inicial:");
            decimal kmInicialValor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe a quilometragem final:");
            decimal kmFinallValor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe o consumo de combustivel:");
            decimal consumoValor = Convert.ToDecimal(Console.ReadLine());

            decimal consumoFinal = kmInicialValor - kmFinallValor / consumoValor;


            Console.WriteLine($"O consumo eh: {consumoFinal}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
