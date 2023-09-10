namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int numero1, numero2, numero3;

            Console.WriteLine("Introduce la cantidad de numeros: ");
            numeros = int.Parse(Console.ReadLine());

            numero1 = 0;
            numero2 = 1;

            Console.Write(numero1 + "" + numero2 + "");

            for (int i = 3; i <= numeros; i++)
            {
                numero3 = numero1 + numero2;
                Console.Write(numero3 + "");
                numero1 = numero2;
                numero2 = numero3;
            }

            Console.ReadKey();
        }
    }
}