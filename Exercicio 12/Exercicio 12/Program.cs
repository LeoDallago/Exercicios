namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 12");

            Console.WriteLine("Por favor, informe o COMPRIMENTO da area: ");
            string comprimento = Console.ReadLine();
            decimal comprimentoValor = Convert.ToDecimal(comprimento);

            Console.WriteLine("Por favor, informe a LARGURA da area: ");
            string largura = Console.ReadLine();
            decimal larguraValor = Convert.ToDecimal(largura);

            decimal area = comprimentoValor * larguraValor;

            Console.WriteLine($"A area eh : {area}");

            //Manten o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}