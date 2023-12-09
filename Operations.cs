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
                Menu();
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
                Menu();
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
            Menu();
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
            Menu();
        }

        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Operations.Soma();
                    break;
                case 2:
                    Operations.Subtracao();
                    break;
                case 3:
                    Operations.Divisao();
                    break;
                case 4:
                    Operations.Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }

        }
    }


}