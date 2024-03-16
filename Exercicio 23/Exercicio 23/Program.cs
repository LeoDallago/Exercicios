namespace Exercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 23");

            int valor = 0;
            int outroValor = 0;
            int valorTotal = 0;

            while (valor >= 0 && valor < 500) {

                outroValor = outroValor + 3;

                 if(outroValor % 2 != 0) {
                    valor = outroValor;
                    Console.WriteLine(valor);
                }


                valorTotal = valor + valorTotal;
            }
            Console.WriteLine($"A soma total eh {valorTotal}");
            Console.ReadLine();
        }
    }
}
