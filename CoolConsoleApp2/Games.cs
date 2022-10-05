using System;
using System.Threading;


namespace CoolConsoleApp2
{
    class Games
    {
        public void RandomNum()
        {
            Console.Clear();

            Graphic _Graphic = new Graphic();
            Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
            string numRndMenu = $@"█████████████████████████████████
 █                             █ 
██  Угадай число от 1 до 100.  ██
 █                             █ 
██              ?              ██
 █                             █ 
██                             ██
 █                             █ 
██                             ██
 █                             █ 
█████████████████████████████████";
            Console.WriteLine(numRndMenu);

            Random random = new Random();
            int rndNum = random.Next(1, 101);
            
            ConsoleKey keyPressed;

            do
            {
                int numInput = Convert.ToInt32(Console.ReadLine());

                if (numInput == rndNum)
                {
                    Console.Clear();
                    Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                    string numRndMenu1 = $@"█████████████████████████████████
 █                             █ 
██  Угадай число от 1 до 100.  ██
 █                             █ 
██              {rndNum}             ██
 █                             █ 
██                             ██
 █                             █ 
██       ТЫ ПОБЕДИЛ!!!         ██
 █                             █ 
█████████████████████████████████";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(numRndMenu1);
                    Console.ReadKey();
                    Console.ResetColor();
                    RandomNum();
                }
                else if (Math.Abs(rndNum - numInput) < 10)
                {
                    Console.Clear();
                    Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                    string numRndMenu2 = $@"█████████████████████████████████
 █                             █ 
██  Угадай число от 1 до 100.  ██
 █                             █ 
██              ?              ██
 █                             █ 
██                             ██
 █                             █ 
██       ТЫ БЛИЗКО!!!!         ██
 █                             █ 
█████████████████████████████████";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(numRndMenu2);
                    Thread.Sleep(300);
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                    Console.WriteLine(numRndMenu2);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                    string numRndMenu3 = $@"█████████████████████████████████
 █                             █ 
██  Угадай число от 1 до 100.  ██
 █                             █ 
██              ?              ██
 █                             █ 
██                             ██
 █                             █ 
██          ДАЛЕКО!!!!         ██
 █                             █ 
█████████████████████████████████";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(numRndMenu3);
                    Thread.Sleep(300);
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                    Console.WriteLine(numRndMenu3);
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
            } while (keyPressed != ConsoleKey.Escape);
            
            Console.ResetColor();
            Console.Clear();
            _Graphic.ProgramLogo();
            
            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();
        }
        
        public void DisplayMultiTab()
        {
            Console.Clear();
            Graphic _Graphic = new Graphic();
            
            ConsoleKey keyPressed;
            do
            {
                Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("--------------------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 1; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(i + "   |  ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write("\t" + i*j);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
            } while (keyPressed != ConsoleKey.Escape);

            Console.ResetColor();
            Console.Clear();
            _Graphic.ProgramLogo();

            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();
        }
        
        public void Divisoin()
        {
            Console.Clear();
            Graphic _Graphic = new Graphic();

            ConsoleKey keyPressed;
            do
            {
                Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");

                Console.Write("Введите число, чтобы узнать все числа, которые делят это число на цело, без остатка: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\nДелители числа {num}: ");
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write( i + " ");
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
            } while (keyPressed != ConsoleKey.Escape);

            Console.ResetColor();
            Console.Clear();
            _Graphic.ProgramLogo();

            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();
        }
    }
}
