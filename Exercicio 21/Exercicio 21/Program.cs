namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 21");

            Console.WriteLine("Por favor, informe o PRIMEIRO numero: ");
            string primeiro = Console.ReadLine();
            int primeiroValor = Convert.ToInt32(primeiro);


            Console.WriteLine("Por favor, informe o SEGUNDO numero: ");
            string segundo = Console.ReadLine();
            int segundoValor = Convert.ToInt32(segundo);

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
