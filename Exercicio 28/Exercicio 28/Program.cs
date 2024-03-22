namespace Exercicio_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 28");

            Console.WriteLine("Por favor, informe o tipo de taboada (1 para IMPAR) (2 para PAR)");
            int tipo = Convert.ToInt32(Console.ReadLine());

            int contador = 0;

            if (tipo != 1 && tipo != 2)
            {
                Console.WriteLine("Operacao invalida");
            }
            else if (tipo == 1)
            {
                contador = 1;
                GeraTaboada(contador);

            }

            else if (tipo == 2)
            {
                contador = 0;
                GeraTaboada(contador);

            }


            Console.ReadLine();
        }

        private static int GeraTaboada(int contador)
        {
            while (contador <= 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i}x{contador} = {i * contador}");
                }
                Console.Write("\n");
                contador += 2;

            }

            return contador;
        }
    }
}
