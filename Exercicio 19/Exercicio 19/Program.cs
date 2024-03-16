namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 19");

            Console.WriteLine("Por favor, informe seu PESO: ");
            string peso = Console.ReadLine();
            decimal pesoValor = Convert.ToDecimal(peso);

            Console.WriteLine("por favor, informe sua ALTURA (em Metros): ");
            string altura = Console.ReadLine();
            decimal alturaValor = Convert.ToDecimal(altura);

            decimal imc = pesoValor / (alturaValor * alturaValor);
          
            if (imc <= 18.5m) {
                Console.WriteLine($"Seu IMC esta abaixo do ideal ({imc})");
            }
            else if(imc >= 18.5m && imc <= 25)
            {
                Console.WriteLine($"Seu IMC esta em condicao ideal ({imc})");
            }
            else if(imc >25 && imc <= 30)
            {
                Console.WriteLine($"Seu IMC esta acima do ideal ({imc})");
            }
            else
            {
                Console.WriteLine($"Seu IMC esta muito acima do ideal (obesidade) ({imc})");
            }

            Console.ReadLine();
        }
    }
}
