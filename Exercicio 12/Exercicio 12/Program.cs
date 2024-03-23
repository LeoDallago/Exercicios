namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 12");

            Console.WriteLine("Por favor, informe o COMPRIMENTO da area: ");
            decimal comprimentoValor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe a LARGURA da area: ");
            decimal larguraValor = Convert.ToDecimal(Console.ReadLine());

            decimal area = comprimentoValor * larguraValor;

            Console.WriteLine($"A area eh : {area}");

            //Manten o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}