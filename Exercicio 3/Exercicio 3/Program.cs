namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3");

            Console.WriteLine("Por favor, informe o raio da cilindro:");
            string raio = Console.ReadLine();
            decimal raioValor = Convert.ToDecimal(raio);

            Console.WriteLine("Por favor, informe a altura da cilindro:");
            string altura = Console.ReadLine();
            decimal alturaValor = Convert.ToDecimal(altura);

            decimal raio2 = raioValor * raioValor;

            decimal pi = 3.14M;

            decimal volume = pi * raio2 * alturaValor;

            Console.WriteLine($"O volume do cilindro eh: {volume}");


            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
