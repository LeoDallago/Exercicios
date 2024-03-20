namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");

            Console.WriteLine("Por favor, informe os valores da caixa");

            decimal comprimento = ObterValor("Informe o Comprimento");
            decimal largura = ObterValor("Informe a Largura");
            decimal altura = ObterValor("Informe a Altura");

            /*  decimal volume = 0; */

            decimal volume = CalculaVolume(comprimento, largura, altura);

            Console.WriteLine($"O valume eh: {volume}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }

        static decimal ObterValor(string texto)
        {
            Console.WriteLine(texto);
            decimal converterValor = Convert.ToDecimal(Console.ReadLine());

            return converterValor;
        }

        static decimal CalculaVolume(decimal comprimento, decimal largura, decimal altura)
        {
            return comprimento * largura * altura;
        }
    }
}
