namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2 (ou exercicio 6 me confundi :)");

            Console.WriteLine("Por favor, informe a temperatura em celsius:");
            decimal temperaturaValor = Convert.ToDecimal(Console.ReadLine());


            decimal convercao = 0;
            convercao = temperaturaValor * 9 / 5 + 32;

            Console.WriteLine($"a temperatura em fahrenheit eh: {convercao}ºF");

        

            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
