namespace Exercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 26");

            Console.WriteLine("Por favor, informe um numero");
            int numeroValor = Convert.ToInt32(Console.ReadLine());

            int soma = 0;
            int valor1 = 1;
            int valor2 = 1;

            for(int i  = 0; i < numeroValor; i++)
            {
                soma = valor1 + valor2;
                valor2 = valor1;
                valor1 = soma;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
