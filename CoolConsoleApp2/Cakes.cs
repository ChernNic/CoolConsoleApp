using System;
using System.Collections.Generic;
using System.IO;
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
        private int price;
        private string Cake;

        public void Menu()
        {
            Console.Clear();

            ConsoleKey keyPressed;

            Label = "Пироги.";

            string[] options = { "Форма торта", "Размер торта", "Вкус коржей", "Количество коржей", "Глазурь", "Декор", "Конец заказа" };
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuForm();
                    break;
                case 1:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuSize();
                    break;
                case 2:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuTaste();
                    break;
                case 3:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuCountOfCakeSlice();
                    break;
                case 4:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuGlaze();
                    break;
                case 5:
                    SelectedIndex = 0;
                    Console.Clear();
                    MenuDecor();
                    break;
                case 6:
                    SelectedIndex = 0;
                    AddOrderToBook();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nЗаказ создан. Для выхода нажмите ESC.");
                    Console.ResetColor();
                    break;
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.Escape)
            {
                Console.Clear();
                Graphic _Graphic = new Graphic();
                _Graphic.ProgramLogo();
                KeyboardMenu mainMenu = new KeyboardMenu();
                mainMenu.MainMenu();
            }
            Menu();
        }

        private void MenuForm()
        {
            Label = "Форма";

            string[] options = { "Круг - 500", "Квадрат - 500", "Сердечко - 600", "Звездочка - 600" };
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price += 500;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    price += 500;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    price += 600;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    price += 600;
                    Cake += options[3] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuSize()
        {

            Label = "Размер.";

            string[] options = { "Маленький (Диаметр - 16 см, 8 порций) - 1000", "Обычный (Диаметр - 18 см, 10 порций) - 1200", "Большой (Диаметр - 28 см, 24 порций) - 2000"};
            Options = new List<string>(options);
            
            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price += 1000;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    price += 1200;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    price += 2000;
                    Cake += options[2] + "; ";
                    break;
            }
            
            Console.Clear();
            Menu();
        }

        private void MenuCountOfCakeSlice()
        {
            Label = "Количество коржей";

            string[] options = { "1 - 100", "2 - 200", "3 - 300", "4 - 400", "WiseTree" };
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price = price + 100;
                    Cake += "Количество коржей: " + options[0] + "; ";
                    break;
                case 1:
                    price += 200;
                    Cake += "Количество коржей: " + options[1] + "; ";
                    break;
                case 2:
                    price += 300;
                    Cake += "Количество коржей: " + options[2] + "; ";
                    break;
                case 3:
                    price += 400;
                    Cake += "Количество коржей: " + options[3] + "; ";
                    break;
                case 4:
                    Graphic graphic = new Graphic();
                    graphic.WiseTree();
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuTaste()
        {
            Label = "Вкус коржей";

            string[] options = { "Ванильны - 100", "Шоколадный - 100", "Карамельный - 150", "Ягодный - 100", "WiseTree" };
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price = price + 100;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    price += 100;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    price += 150;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    price += 100;
                    Cake += options[3] + "; ";
                    break;
                case 4:
                    Graphic graphic = new Graphic();
                    graphic.WiseTree();
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuGlaze()
        {
            Label = "Вкус глазури";

            string[] options = { "Ванильная - 300", "Шоколадная - 200", "Карамельная - 250", "Ягодная - 200"};
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price = price + 400;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    price += 200;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    price += 250;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    price += 200;
                    Cake += options[3] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuDecor()
        {
            Label = "Декор";

            string[] options = { "Ягоды - 300", "Шоколадная крошка - 200", "Окрошка - 250", "Окошко - 200", "Баяс - 20000", "WiseTree" };
            Options = new List<string>(options);

            int selectedIndex = Run();

            switch (selectedIndex)
            {
                case 0:
                    price = price + 300;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    price += 200;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    price += 250;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    price += 200;
                    Cake += options[3] + "; ";
                    break;
                case 4:
                    price += 20000;
                    Cake += options[4] + "; ";
                    break;
                case 5:
                    Graphic graphic = new Graphic();
                    graphic.WiseTree();
                    break;
            }

            Console.Clear();
            Menu();
        }


        private void AddOrderToBook()
        {
            string order = $"{DateTime.Now}   Цена заказа: {price}. Заказ: {Cake}\n";
            string path = @"C:\Users\chern\Desktop\C# projects\CoolConsoleApp2\Order\Orders.txt";
            File.AppendAllText(path, order);
        }

        //MЕНЮ
        private void DisplayOptions()
        {
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nЦена: {price} \nВаш торт: {Cake}");
            Console.ResetColor();
        }

        private int Run()
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
