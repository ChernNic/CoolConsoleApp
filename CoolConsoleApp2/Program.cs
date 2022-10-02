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
            Console.SetWindowSize(150,30);
            ProgramLogoStart();

            Console.ReadKey();
        }
        
        static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  __  __         _            __  __                     \r\n |  \\/  |       (_)          |  \\/  |                    \r\n | \\  / |  __ _  _  _ __     | \\  / |  ___  _ __   _   _ \r\n | |\\/| | / _` || || '_ \\    | |\\/| | / _ \\| '_ \\ | | | |\r\n | |  | || (_| || || | | |   | |  | ||  __/| | | || |_| |\r\n |_|  |_| \\__,_||_||_| |_|   |_|  |_| \\___||_| |_| \\__,_|\r\n                                                         \r\n                                                        ");


        }
        
        static void ProgramLogoStart()
        {
            List<string> logoAuthor = new List<string> { "B", "Y", " ", "C", "H", "E", "R", "N", "_", "N", "I", "C" };
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
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

        static void MusicPlayer()
        {
            Thread currentThread = Thread.CurrentThread;
            int octave;
            string song_input;
            char[,] SongSheet;

            while (true)
            {
                octave = Convert.ToInt32(Console.ReadLine());
                song_input = Console.ReadLine();
                char[] octave_line = song_input.ToCharArray();
                SongSheet = new char[9, song_input.Length];
                if 
            }
            Console.WriteLine(SongSheet[1,1]);

            int[,] Notes_frequency = new int [ 9, 12 ] 
             // c      C      d     D    e     f    F      g     G     a     A     b
            { { 16,    17,   18,   19,  21,   22,   23,   25,   26,   28,   29,   31 },
            { 33,   35,   37,   39,   42,   44,   46,   49,   51,   55,   58,   62 },
            { 65,   69,   73,   78,   82,   87,   93,   98,   104,   110,   116,   123 },
            { 131,   139,   147,   156,   165,   175,   185,  196,   208,   220,  233,  246 },
            { 262,   277,   294,   311,   330,   349,   370,   392,   415,   440,   466,   494 },
            { 523,   554,   587,   622,   659,   699,   740,  784,   831,   880,   932,   988 },
            { 1047,  1109,    1175,    1245,    1319,    1397,    1480,    1568,    1661,    1760,    1865,  1976 },
            { 2093,    2217,    2349,    2489,    2637,    2794,    2960,    3136,    3322,    3520,    3729,    3951 },
            { 4186,    4435,    4699,    4978,    5274,    5588,    5920,    6272,    6645,    7040,    7459,    7902 } };
            


        }
    }
}
