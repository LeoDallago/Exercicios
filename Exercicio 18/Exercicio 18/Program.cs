namespace Exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 18");

            Console.WriteLine("Por favor, informe o PRIMEIRO valor");
            int primeiroValor  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o SEGUNDO valor");
            int segundoValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o TERCEIRO valor");
            int terceiroValor = Convert.ToInt32(Console.ReadLine());


            if (primeiroValor > segundoValor && segundoValor > terceiroValor)
            {
                Console.WriteLine($"{primeiroValor},{segundoValor},{terceiroValor}");
            }
           else if (primeiroValor > terceiroValor && terceiroValor > segundoValor)
            {
                Console.WriteLine($"{primeiroValor},{terceiroValor},{segundoValor}");
            }
            else if(segundoValor > primeiroValor && primeiroValor > terceiroValor)
            {
                Console.WriteLine($"{segundoValor},{primeiroValor},{terceiroValor}");
            }
            else if (segundoValor > terceiroValor && terceiroValor > primeiroValor)
            {
                Console.WriteLine($"{segundoValor},{terceiroValor},{primeiroValor}");
            }

            else if (terceiroValor > segundoValor && segundoValor > primeiroValor)
            {
                Console.WriteLine($"{terceiroValor},{segundoValor},{primeiroValor}");
            }
            else
            {
                Console.WriteLine($"{terceiroValor},{primeiroValor},{segundoValor}");
            }

            Console.ReadLine();
        }
    }
}
