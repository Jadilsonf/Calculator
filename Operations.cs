using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
        {

        internal static void Soma()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                var v1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Segunda valor: ");
                Double v2 = Double.Parse(Console.ReadLine());

                Double resultado = v1 + v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da soma é {resultado}");
                Console.ReadKey();
            }

        internal static void Subtracao()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                var v1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Segunda valor: ");
                Double v2 = Double.Parse(Console.ReadLine());

                Double resultado = v1 - v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
            }

        internal static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segunda valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Double resultado = v1 / v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadKey();
        }

        internal static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segunda valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Double resultado = v1 * v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
        }
    }


}