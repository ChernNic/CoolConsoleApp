﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CoolConsoleApp2
{
    class MusicPlayer
    {

        static void Player()
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

            }
            Console.WriteLine(SongSheet[1, 1]);

            int[,] Notes_frequency = new int[9, 12] 
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
