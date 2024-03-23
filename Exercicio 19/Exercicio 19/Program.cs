namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 19");

            Console.WriteLine("Por favor, informe seu PESO: ");
            decimal pesoValor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("por favor, informe sua ALTURA (em Metros): ");
            decimal alturaValor = Convert.ToDecimal(Console.ReadLine());

            decimal imc = pesoValor / (alturaValor * alturaValor);
          
            ResultadoIMC(imc);

            Console.ReadLine();
        }

        static void ResultadoIMC(decimal imc){
             if (imc <= 18.5m) {
                Console.WriteLine($"Seu IMC esta abaixo do ideal ({imc.ToString("N2")})");
            }
            else if(imc >= 18.5m && imc <= 25)
            {
                Console.WriteLine($"Seu IMC esta em condicao ideal ({imc.ToString("N2")})");
            }
            else if(imc >25 && imc <= 30)
            {
                Console.WriteLine($"Seu IMC esta acima do ideal ({imc.ToString("N2")})");
            }
            else
            {
                Console.WriteLine($"Seu IMC esta muito acima do ideal (obesidade) ({imc.ToString("N2")})");
            }
        }
    }
}
