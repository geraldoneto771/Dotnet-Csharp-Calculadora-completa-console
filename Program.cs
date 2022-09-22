// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static public short resposta;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Qual operação matemática você deseja realizar?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("---------------------------------------------");
                Console.Write("Selecione uma opção: ");
                resposta = short.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Soma(); break;
                    case 2:
                        Subtracao(); break;
                    case 3:
                        Divisao(); break;
                    case 4:
                        Multiplicacao(); break;
                    case 5:
                        //finalizar execução
                        System.Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Opção incorreta!"); break;
                }
            } while (resposta != 5);


        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 + v2);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 - v2);
            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 / v2);
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = (v1 * v2);

            Console.WriteLine("");
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
            Console.ReadKey();
        }
    }
}
