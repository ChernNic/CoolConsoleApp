using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphic _Graphic = new Graphic();
            _Graphic.ProgramLogoStart();

            string label = "Выберите то что хтоте:";
            string[] options = { "Option1", "Option2", "lobster", "Exit" };

            KeyboardMenu mainMenu = new KeyboardMenu(label, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:
                    _Graphic.lobster();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
