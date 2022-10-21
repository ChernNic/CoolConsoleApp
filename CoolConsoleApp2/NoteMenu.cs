using System;
using System.Threading;

namespace CoolConsoleApp2
{
    class NoteMenu
    {


        private int SelectedIndex;
        private string Label = "МЕНЮ ЗАМЕТОК \n";
        private string Label2 = "Выберите действие:\n";
        private string[] Options = { "Создать заметку", "Поиск заметок", "Вернуться в главное меню." };

        public void Menu()
        {
            Console.Clear();
            Console.ResetColor();
            NoteMenu noteMenu = new NoteMenu();
            int selectedIndex = noteMenu.Run();

            Notepad notepad = new Notepad();

            switch (selectedIndex)
            {
                case 0:
                    notepad.AddNote();
                    break;
                case 1:
                    notepad.PrintNotesList();
                    break;
                case 2:
                    KeyboardMenu mainMenu = new KeyboardMenu();
                    Graphic _Graphic = new Graphic();
                    Console.ResetColor();
                    Console.Clear();
                    _Graphic.ProgramLogo();
                    mainMenu.MainMenu();
                    break;
            }
        }

        public void DisplayOptions()
        {

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Label);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сегодня: " + DateTime.Now.ToString("dd'.'MM'.'yyyy") + "\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Label2);

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
                    Console.ForegroundColor = ConsoleColor.Yellow;
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
