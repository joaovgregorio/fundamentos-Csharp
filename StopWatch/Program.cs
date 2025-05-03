using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();

            StopWatchLogo();
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("S = Segundos => 10s");
            Console.WriteLine("M = Minutos => 10m");
            Console.WriteLine("E = Encerrar/Sair");

            Console.ResetColor();
            Console.Write("\n" + $"Digite o tempo desejado que o temporizador conte: ");

            string userOption = Console.ReadLine().ToLower();
            char dataType = char.Parse(userOption.Substring(userOption.Length - 1));
            int time = int.Parse(userOption.Substring(0, userOption.Length - 1));

            Start(time);
        }

        private static void Start(int time)
        {
            if (time <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + $"O tempo deve ser maior que zero!!!".ToUpper());
                Thread.Sleep(2000);
                Console.ResetColor();
                Main();
            }

            for (int i = 0; i <= time; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Temporizador {time - i} segundos");
                Thread.Sleep(1000);
            }

            Console.ResetColor();
        }

        private static void StopWatchLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string logo = @"
                █─▄▄▄▄█─▄─▄─█─▄▄─█▄─▄▄─█▄─█▀▀▀█─▄██▀▄─██─▄─▄─█─▄▄▄─█─█─█
                █▄▄▄▄─███─███─██─██─▄▄▄██─█─█─█─███─▀─████─███─███▀█─▄─█
                ▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▀▄▄▄▀▀▀▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▀▄▀
            ";

            Console.WriteLine(logo);
            Console.ResetColor();
        }
    }
}