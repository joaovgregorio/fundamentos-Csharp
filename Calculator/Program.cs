using System;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();
            Console.ResetColor();

            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            ExibirMenu();

            Console.Write("Escolha uma opção: ");
            short escolhaDoUsuario = short.Parse(Console.ReadLine());

            switch (escolhaDoUsuario)
            {
                case 1:
                    Console.WriteLine("\n" + $"A soma entre {primeiroValor} e {segundoValor} é {Somar(primeiroValor, segundoValor)}");
                    Thread.Sleep(4000);
                    break;

                case 2:
                    Console.WriteLine("\n" + $"A subtração entre {primeiroValor} e {segundoValor} é {Subtrair(primeiroValor, segundoValor)}");
                    Thread.Sleep(4000);
                    break;

                case 3:
                    Console.WriteLine("\n" + $"A multiplicação entre {primeiroValor} e {segundoValor} é {Multiplicar(primeiroValor, segundoValor)}");
                    Thread.Sleep(4000);
                    break;

                case 4:
                    Console.WriteLine("\n" + $"A divisão entre {primeiroValor} e {segundoValor} é {Dividir(primeiroValor, segundoValor)}");
                    Thread.Sleep(4000);
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n" + "Aplicação encerrada!!!".ToUpper());
                    Console.ResetColor();
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n" + "Opção inválida. Tente novamente.".ToUpper());
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Main();
                    break;
            }

            IniciarNovaOperacao();
        }

        private static void ExibirMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + "1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair" + "\n");
            Console.ResetColor();
        }

        private static float Somar(float primeiroValor, float segundoValor) => primeiroValor + segundoValor;

        private static float Subtrair(float primeiroValor, float segundoValor) => primeiroValor - segundoValor;

        private static float Multiplicar(float primeiroValor, float segundoValor) => primeiroValor * segundoValor;

        private static float Dividir(float primeiroValor, float segundoValor)
        {
            if (segundoValor == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Divisão por zero não é permitida.");
                Console.ResetColor();
                return 0;
            }
            return primeiroValor / segundoValor;
        }

        private static void IniciarNovaOperacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\n" + "Deseja realizar outra operação (S/N)? ");
            Console.ResetColor();

            char resposta = char.Parse(Console.ReadLine().ToUpper());

            if (resposta == 'S') Main();
            else if (resposta == 'N')
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n" + "Aplicação encerrada!!!".ToUpper());
                Console.ResetColor();
                System.Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n" + "Opção inválida. Tente novamente.".ToUpper());
                Thread.Sleep(3000);
                Console.ResetColor();
                IniciarNovaOperacao();
            }
        }
    }
}