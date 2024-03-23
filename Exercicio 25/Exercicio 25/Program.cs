namespace Exercicio_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 25");

            Console.WriteLine("Por favor, informe um numero");
            int numeroValor = Convert.ToInt32(Console.ReadLine());

            int calculo = numeroValor;

            while (numeroValor > 1)
            {

                numeroValor--;
                calculo *= numeroValor;

            }

           Console.WriteLine($"O resultado do fatorial eh {calculo}");

            Console.ReadLine();
        }
    }
}
