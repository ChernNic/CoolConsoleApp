using System;
using System.Threading;

namespace CoolConsoleApp2
{
    class KeyboardMenu
    {
        private int SelectedIndex;
        private string Label = "Выберите то, что хотите:";
        private string[] Options = { "Таблица умножения", "Игра Угадай число", "Делители числа", "lobster", "Пианино" , "Заметки", "Пироги", "Exit" };

        public void MainMenu()
        {
            KeyboardMenu mainMenu = new KeyboardMenu();
            int selectedIndex = mainMenu.Run();

            Notepad notepad = new Notepad();

            Graphic _Graphic = new Graphic();
            Piano piano = new Piano();
            Games games = new Games();
            Cakes cakes = new Cakes();

            switch (selectedIndex)
            {
                case 0:
                    games.DisplayMultiTab();
                    break;
                case 1:
                    games.RandomNum();
                    break;
                case 2:
                    games.Divisoin();
                    break;
                case 3:
                    _Graphic.lobster();
                    break;
                case 4:
                    piano.Run();
                    break;
                case 5:
                    notepad.Menu();
                    break;
                case 6:
                    cakes.Menu();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public void DisplayOptions()
        {
            Console.SetCursorPosition(80 - Label.Length, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Label);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else if (i == Options.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.SetCursorPosition(65 - Options[i].Length/2, 10 + i);
                Console.WriteLine($"<< {currentOption} >>");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            Graphic _Graphic = new Graphic();
            ConsoleKey keyPressed;

            do
            {
                new Thread(DisplayOptions).Start();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
