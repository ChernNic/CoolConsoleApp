using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CoolConsoleApp2
{
    class KeyboardMenu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Label;

        public KeyboardMenu(string label, string[] options)
        {
            Label = label;
            Options = options;
            SelectedIndex = 0;
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
                //Console.Clear();
                //_Graphic.NumArr();
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
