
namespace Exercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 24");

            Console.WriteLine("Por favor, informe um numero:");
            int numeroValor = Convert.ToInt32(Console.ReadLine());

            if (numeroValor >=1 && numeroValor <=10) {
                for (int i = 100; i <= 10; i++)
                {
                    Console.WriteLine($"{numeroValor}x{i} = {i*numeroValor}");
                }
            }
            else
            {
                Console.WriteLine("Numero Invalido!");
            }

            Console.ReadLine();
        }
    }
}
