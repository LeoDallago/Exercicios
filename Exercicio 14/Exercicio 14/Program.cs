namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 14");

            Console.WriteLine("Por favor, informe seu NOME: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Por favor, informe a sua IDADE : ");
            string idade = Console.ReadLine();
            int idadeValor = Convert.ToInt32(idade);

            int diasDeVida = idadeValor * 365;

            Console.WriteLine($"{nome}, voce ja viveu {diasDeVida} dias.");

            //Mantem o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}
