namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 16");

            Console.WriteLine("Por favor, informe o salario INICIAL: ");
            decimal salarioInicialValor = Convert.ToDecimal(Console.ReadLine());

            decimal aumento = 0.15m * salarioInicialValor;

            decimal salarioAumento = salarioInicialValor + aumento;

           decimal salarioFinal = salarioInicialValor + aumento - (salarioInicialValor * 0.08m);

            Console.WriteLine($"salario INICIAL: {salarioInicialValor} ");
            Console.WriteLine($"salario com AUMENTO: {salarioAumento} ");
            Console.WriteLine($"salario FINAL (com descontos): {salarioFinal} ");

            //Mantem o programa aberto (nao apagar)
            Console.ReadLine();
        }
    }
}
