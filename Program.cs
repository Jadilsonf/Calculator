using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Segunda valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Double resultado = v1 + v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado é {resultado}");

        }
    }
}