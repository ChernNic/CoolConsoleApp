using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolConsoleApp2
{
    internal class Cakes
    {
        Notepad notepad = new Notepad();

        private int SelectedIndex;
        private string Label;
        private List<string> Options;

        public void FirstMenu()
        {
            ConsoleKey keyPressed;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                Label = "Пироги";

                string[] options = { "Форма торта", "Размер торта", "Количество коржей", "Вкус коржей", "Крем", "Глазурь", "Декор", "Конец заказа" };
                Options = new List<string>(options);

                int selectedIndex = Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        MenuFormOfCake();
                        break;
                }

            } while (keyPressed != ConsoleKey.Escape);
        }

        public void MenuFormOfCake()
        {
            ConsoleKey keyPressed;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                Label = "Форма";

                string[] options = { "Круг - 500", "Квадрат - 500", "Сердечко - 600", "Звездочка - 600" };
                Options = new List<string>(options);

                int selectedIndex = Run();

                switch (selectedIndex)
                {
                    case 0:

                        break;
                }

            } while (keyPressed != ConsoleKey.Escape);
        }


        public void DisplayOptions()
        {
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Label);

            for (int i = 0; i < Options.Capacity; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else if (i == Options.Capacity - 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

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
                        SelectedIndex = Options.Capacity - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Capacity)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
