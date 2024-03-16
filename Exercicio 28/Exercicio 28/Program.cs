namespace Exercicio_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 28");

          for (int j = 0; j <= 10; j++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i}x{j} = {i * j}");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
