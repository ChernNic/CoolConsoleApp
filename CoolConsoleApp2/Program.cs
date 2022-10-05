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
            _Graphic.ProgramLogo();



            string label = "Выберите то что хтоте:";
            string[] options = { "Option1", "Option2", "Option3" };

            KeyboardMenu mainMenu = new KeyboardMenu(label, options);
            int selectedIndex = mainMenu.Run();


            Console.ReadKey();
        }
    }
}
