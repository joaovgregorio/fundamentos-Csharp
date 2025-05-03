using System;
using System.Threading;

namespace EditorHTML
{
    public static class Menu
    {
        public static string logo = @"
            ╔═╗╔╦╦╗─────╔╗╔╦══╦═╦═╦╗
            ║╦╬╝╠╣╚╦═╦╦╗║╚╝╠╗╔╣║║║║║
            ║╩╣╬║║╔╣╬║╔╝║╔╗║║║║║║║║╚╗
            ╚═╩═╩╩═╩═╩╝─╚╝╚╝╚╝╚╩═╩╩═╝
        ";

        public static void Show()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

            DrawScreen();
            WriteOptions();

            Console.ResetColor();
        }

        public static void DrawScreen()
        {
            DrawLines();
            DrawColumns();
            DrawLines();

            //short option = short.Parse(Console.ReadLine());
        }

        public static void DrawLines()
        {
            Console.Write(" ^ ");

            for (int i = 0; i <= 80; i++)
                Console.Write("-");

            Console.WriteLine("^");
        }

        public static void DrawColumns()
        {
            for (int lines = 0; lines <= 15; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 80; i++)
                    Console.Write(" ");

                Console.Write("|" + "\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(35, 1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(logo);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("1 - Criar um novo arquivo");

            Console.SetCursorPosition(15, 8);
            Console.WriteLine("2 - Abrir um arquivo");

            Console.SetCursorPosition(15, 9);
            Console.WriteLine("3 - Excluir um arquivo" + "\n");

            Console.SetCursorPosition(15, 10);
            Console.WriteLine("0 - Sair/Encerrar aplicação" + "\n");
            Console.ResetColor();

            Console.SetCursorPosition(15, 12);
            Console.Write("Escolha uma opção: ");

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Programa encerrado...".ToUpper());
                        Thread.Sleep(1000);
                        System.Environment.Exit(0);
                    }
                    break;

                case 1:
                    Console.WriteLine("Criar");
                    break;

                case 2:
                    Console.WriteLine("Abrir");
                    break;

                case 3:
                    Console.WriteLine("Excluir");
                    break;

                default:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida, tente novamente".ToUpper());
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        Show();
                    }
                    break;
            }
        }
    }
}