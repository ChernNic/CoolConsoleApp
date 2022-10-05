using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CoolConsoleApp2
{
    class Graphic
    {
        public void ProgramLogoStart()
        {
            Console.SetWindowSize(150, 30);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            List<string> logoAuthor = new List<string> { "B", "Y", " ", "C", "H", "E", "R", "N", "_", "N", "I", "C" };

            Console.Write("______   ______   ______   __                 ______   ______   __   __   ______   ______   __       ______             ______   ______  ______  \n");
            Thread.Sleep(200);
            Console.Write("/\\  ___\\ /\\  __ \\ /\\  __ \\ /\\ \\               /\\  ___\\ /\\  __ \\ /\\ \"-.\\ \\ /\\  ___\\ /\\  __ \\ /\\ \\     /\\  ___\\           /\\  __ \\ /\\  == \\/\\  == \\ \n");
            Thread.Sleep(200);
            Console.Write("\\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\/\\ \\\\ \\ \\____          \\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\-.  \\\\ \\___  \\\\ \\ \\/\\ \\\\ \\ \\____\\ \\  __\\           \\ \\  __ \\\\ \\  _-/\\ \\  _-/ \n");
            Thread.Sleep(200);
            Console.Write(" \\ \\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_____\\\\ \\_____\\\\ \\_\\\\\"\\_\\\\/\\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_\\ \\_\\\\ \\_\\   \\ \\_\\   \n");
            Thread.Sleep(200);
            Console.Write("  \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_____/ \\/_____/ \\/_/ \\/_/ \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_/\\/_/ \\/_/    \\/_/   ");
            Thread.Sleep(200);

            Console.SetCursorPosition(75 - logoAuthor.Count, 6);
            for (int i = 0; i < logoAuthor.Count; i++)
            {
                Console.Write(logoAuthor[i]);
                Thread.Sleep(200);
            }
        }

        public void ProgramLogo()
        {
            Console.SetWindowSize(150, 30);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            List<string> logoAuthor = new List<string> { "B", "Y", " ", "C", "H", "E", "R", "N", "_", "N", "I", "C" };

            Console.Write("______   ______   ______   __                 ______   ______   __   __   ______   ______   __       ______             ______   ______  ______  \n");
            Console.Write("/\\  ___\\ /\\  __ \\ /\\  __ \\ /\\ \\               /\\  ___\\ /\\  __ \\ /\\ \"-.\\ \\ /\\  ___\\ /\\  __ \\ /\\ \\     /\\  ___\\           /\\  __ \\ /\\  == \\/\\  == \\ \n");
            Console.Write("\\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\/\\ \\\\ \\ \\____          \\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\-.  \\\\ \\___  \\\\ \\ \\/\\ \\\\ \\ \\____\\ \\  __\\           \\ \\  __ \\\\ \\  _-/\\ \\  _-/ \n");
            Console.Write(" \\ \\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_____\\\\ \\_____\\\\ \\_\\\\\"\\_\\\\/\\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_\\ \\_\\\\ \\_\\   \\ \\_\\   \n");
            Console.Write("  \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_____/ \\/_____/ \\/_/ \\/_/ \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_/\\/_/ \\/_/    \\/_/   ");

            Console.SetCursorPosition(75 - logoAuthor.Count, 6);
            for (int i = 0; i < logoAuthor.Count; i++)
            {
                Console.Write(logoAuthor[i]);
            }
        }

        public void NumArr()
        {
            string[,] RndNum = new string[22, 149];
            Console.WriteLine();
            Random random = new Random();
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 149; j++)
                {
                    RndNum[i, j] = Convert.ToString(random.Next(2));
                    Console.Write($"{ RndNum[i, j]}");
                }
                Console.WriteLine();
            }
            Array.Clear(RndNum, 22, 149);

            Console.SetCursorPosition(75, 10);
            string[,] Gap = new string[22, 22];
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 149; j++)
                {
                    RndNum[i, j] = "                             ";
                    Console.SetCursorPosition(75, 10+i);
                    Console.Write($"{ RndNum[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
