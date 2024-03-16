namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 7");

            Console.WriteLine("Por favor, informe o salario base: ");
            string salarioBase = Console.ReadLine();
            decimal salarioBaseValor = Convert.ToDecimal(salarioBase);

            Console.WriteLine("Por favor, informe o total de vendas: ");
            string totalVendas = Console.ReadLine();
            decimal totalVendasValor = Convert.ToDecimal(totalVendas);

            Console.WriteLine("Por favor, informe a comissao para o vendedor(a)");
            string comissao = Console.ReadLine();
            decimal comissaoValor = Convert.ToDecimal(comissao);

            decimal salarioTotal = salarioBaseValor+(totalVendasValor * comissaoValor/100);

            Console.WriteLine($"O Salario total do vendedor(a) eh: {salarioTotal}");

            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
