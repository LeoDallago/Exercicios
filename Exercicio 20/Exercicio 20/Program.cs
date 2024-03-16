namespace Exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 20");

            Console.WriteLine("Por favor, informe o numero: ");
            string numero = Console.ReadLine();
            int numeroValor = Convert.ToInt32(numero);

          if(numeroValor % 2 == 0 ) 
            {
                Console.WriteLine("este numero eh PAR");
            }
            else
            {
                Console.WriteLine("este numero eh INPAR");
            }

            Console.ReadLine();
        }
    }
}
