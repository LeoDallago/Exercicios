namespace Exercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 27");

            int num = 1;

            while (num <= 100) { 
            
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0 ) {
                    Console.WriteLine("Fizz");
                }
                else if (num %5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
                num++;
            }

            Console.ReadLine();
        }
    }
}
