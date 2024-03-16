namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 10");

            Console.WriteLine("Por favor, informe a nota 1");
            string nota1 = Console.ReadLine();
            decimal nota1Valor = Convert.ToDecimal(nota1);

            Console.WriteLine("Por favor, informe a nota 2");
            string nota2 = Console.ReadLine();
            decimal nota2Valor = Convert.ToDecimal(nota2);

            Console.WriteLine("Por favor, informe o peso 1");
            string peso1 = Console.ReadLine();
            decimal peso1Valor = Convert.ToDecimal(peso1);

            Console.WriteLine("Por favor, informe o peso 2");
            string peso2 = Console.ReadLine();
            decimal peso2Valor = Convert.ToDecimal(peso2);


            decimal calculo1 = (peso1Valor * nota1Valor) + (peso2Valor * nota2Valor);

            decimal calculo2 = peso1Valor + peso2Valor;

            decimal mediaPonderada = calculo1 / calculo2;

            Console.WriteLine($"A media ponderada eh : {mediaPonderada}");

            //Manten o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}
