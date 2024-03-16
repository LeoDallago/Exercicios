namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5");

            Console.WriteLine("Por favor, informe o raio da esfera:");
            string raio = Console.ReadLine();
            decimal raioValor = Convert.ToDecimal(raio);

            decimal raio3 = raioValor * raioValor * raioValor;

            decimal pi = 3.14m;

            decimal volume = 4/3 * pi * raio3;


            Console.WriteLine($"O volume da esfera eh: {volume}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
