using System.Diagnostics;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 9");

            Console.WriteLine("Informe a nota 1 :");
            decimal nota1Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota 2 :");
            decimal nota2Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota 3 :");
            decimal nota3Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota 4 :");
            decimal nota4Valor = Convert.ToDecimal(Console.ReadLine());

         
            decimal conta = 4 / ((1 / nota1Valor) + (1 / nota2Valor) + (1 / nota3Valor) + (1 / nota4Valor));

            Console.WriteLine($"o resultado eh {conta.ToString("N2")}");


            Console.ReadLine();
        }
    }
}
