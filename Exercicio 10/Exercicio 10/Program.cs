namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 10");

            Console.WriteLine("Por favor, informe a nota 1");
            decimal nota1Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe a nota 2");
            decimal nota2Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe o peso 1");
            decimal peso1Valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor, informe o peso 2");
            decimal peso2Valor = Convert.ToDecimal(Console.ReadLine());


            FazCalculo(nota1Valor,nota2Valor,peso1Valor,peso2Valor);


            //Manten o programa aberto (nao apagar)
            Console.ReadLine();
        }

        static void FazCalculo (decimal nota1Valor, decimal nota2Valor, decimal peso1Valor,decimal peso2Valor){
            
             decimal calculo1 = (peso1Valor * nota1Valor) + (peso2Valor * nota2Valor);

            decimal calculo2 = peso1Valor + peso2Valor;

            decimal mediaPonderada = calculo1 / calculo2;

            Console.WriteLine($"A media ponderada eh : {mediaPonderada}");
        }
    }
}
