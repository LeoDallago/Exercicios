namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");

            Console.WriteLine("Por favor, informe os valores da caixa");

            Console.WriteLine("comprimento");
            string comprimento = Console.ReadLine();
            decimal comprimentoValor = Convert.ToDecimal(comprimento);

            Console.WriteLine("largura");
            string largura = Console.ReadLine();
            decimal larguraValor = Convert.ToDecimal(largura);

            Console.WriteLine("altura");
            string altura = Console.ReadLine();
            decimal alturaValor = Convert.ToDecimal(altura);

            decimal volume = 0;

            volume = comprimentoValor * larguraValor * alturaValor;

            Console.WriteLine($"O valume eh: {volume}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine(); 
        }
    }
}
