namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 7");

            decimal salarioBaseValor = PegaValor("Por favor, informe o salario base: ");
            decimal totalVendasValor = PegaValor("Por favor, informe o total de vendas: ");
            decimal comissaoValor = PegaValor("Por favor, informe a comissao para o vendedor(a)");

            decimal salarioTotal = CalculoSalario(salarioBaseValor, totalVendasValor, comissaoValor);

            Console.WriteLine($"O Salario total do vendedor(a) eh: {salarioTotal}");

            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }

        static decimal PegaValor(string texto)
        {
            Console.WriteLine(texto);

            decimal converterTexto = Convert.ToDecimal(Console.ReadLine());
            return converterTexto;

        }

        static decimal CalculoSalario(decimal salarioBase, decimal vendas, decimal comissao)
        {
            decimal calculo = salarioBase + (vendas * comissao / 100);
            return calculo;
        }
    }
}
