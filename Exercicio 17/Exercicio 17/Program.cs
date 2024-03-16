namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 17");

            Console.WriteLine("Por favor, informe o PRIMEIRO valor: ");
            string primeiro = Console.ReadLine();
            int primeiroValor = Convert.ToInt32(primeiro);

            Console.WriteLine("Por favor, informe o SEGUNDO valor: ");
            string segundo = Console.ReadLine();
            int segundoValor = Convert.ToInt32(segundo);

            Console.WriteLine("Por favor, informe o TERCEIRO valor");
            string terceiro = Console.ReadLine();
            int terceiroValor = Convert.ToInt32(terceiro);

            if(primeiroValor+segundoValor < terceiroValor)
            {
                Console.WriteLine("A soma do primeiro e segundo valor eh MENOR que o terceiro valor!");
            }
            else if(primeiroValor + segundoValor == terceiroValor)
            {
                Console.WriteLine("A soma do primeiro e segundo valor eh IGUAL que o terceiro valor!");
            }
            else
            {
                Console.WriteLine("A soma do primeiro e segundo valor eh MAIOR que o terceiro valor");
            }

            //Mantem o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}
