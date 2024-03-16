using System.Diagnostics;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 9");

            Console.WriteLine("Informe a nota 1 :");
            string nota1 = Console.ReadLine();
            decimal nota1Valor = Convert.ToDecimal(nota1);

            Console.WriteLine("Informe a nota 2 :");
            string nota2 = Console.ReadLine();
            decimal nota2Valor = Convert.ToDecimal(nota2);

            Console.WriteLine("Informe a nota 3 :");
            string nota3 = Console.ReadLine();
            decimal nota3Valor = Convert.ToDecimal(nota3);

            Console.WriteLine("Informe a nota 4 :");
            string nota4 = Console.ReadLine();
            decimal nota4Valor = Convert.ToDecimal(nota4);

         
            decimal conta = 4 / ((1 / nota1Valor) + (1 / nota2Valor) + (1 / nota3Valor) + (1 / nota4Valor));

            Console.WriteLine($"o resultado eh {conta}");


            Console.ReadLine();
        }
    }
}
