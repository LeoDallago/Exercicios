namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6 (ou exercicio 2 me confundi :))");

            Console.WriteLine("Por favor, informe a temperatura em fahrenheit:");
            decimal temperaturaValor = Convert.ToDecimal(Console.ReadLine());

           // decimal calculo = temperaturaValor - 32;

             decimal convercao = (temperaturaValor - 32) * 5 / 9 ;

            Console.WriteLine($"a temperatura em celsius eh: {convercao.ToString("N1")}ºC");
           

            //Não remover esta linha (manter console aberto)
            Console.ReadLine();
        }
    }
}
