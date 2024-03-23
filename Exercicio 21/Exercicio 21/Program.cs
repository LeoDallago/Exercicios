namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 21");

            Console.WriteLine("Por favor, informe o PRIMEIRO numero: ");
            int primeiroValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o SEGUNDO numero: ");
            int segundoValor = Convert.ToInt32(Console.ReadLine());

            int terceiro;

            if(primeiroValor == segundoValor)
            {
                terceiro = primeiroValor + segundoValor;
                Console.WriteLine($"o reasultado eh ADICAO {terceiro}");
            }
            else
            {
                terceiro = primeiroValor * segundoValor;
                Console.WriteLine($"o reasultado eh MULTIPLICACAO {terceiro}");
            }



            Console.ReadLine();
        }
    }
}
