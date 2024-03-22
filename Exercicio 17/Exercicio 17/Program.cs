namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 17");


            int primeiroValor = InformaValor("Por favor, informe o PRIMEIRO valor: ");

            int segundoValor = InformaValor("Por favor, informe o SEGUNDO valor: ");

            int terceiroValor = InformaValor("Por favor, informe o TERCEIRO valor: ");


            if (primeiroValor + segundoValor < terceiroValor)
            {
                Console.WriteLine("A soma do primeiro e segundo valor eh MENOR que o terceiro valor!");
            }
            else if (primeiroValor + segundoValor == terceiroValor)
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

        static int InformaValor(string valor)
        {
            Console.WriteLine(valor);

            int valorPego = Convert.ToInt32(Console.ReadLine());

            return valorPego;
        }
    }
}
