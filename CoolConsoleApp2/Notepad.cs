﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolConsoleApp2
{
    class Notepad
    {
        NoteMenu noteMenu = new NoteMenu();

        DateTime dateTime = DateTime.Today;
        List<Note> notes = new List<Note>();

        private DateTime ReadDateTime()
        {
            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Введите время в формате: [02.12.2012 13:00]:");
            DateTime dateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка попробуйте снова: ");
                Console.ResetColor();
            }
            return dateTime;
        }

        public void AddNote()
        {
            DateTime dateTime = ReadDateTime();

            Console.WriteLine("Введите название заметки: ");
            string name = Console.ReadLine();
            Console.WriteLine(@"Введите текст заметки (для переноса строки используйте \n): ");
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Заметка на {dateTime} успешно созданна!");
            Console.ReadKey();

            notes.Add(new Note(dateTime, name, text));

            notes.Add(new Note(DateTime.Now, "Как пользоваться", @"Используйте стрелки влево и вправо, чтобы перемещаться между датам. \nПо нажатию Enter открывеатся полная информация о заметке."));

            noteMenu.Menu();
            Console.SetCursorPosition(0, 6);
        }

        public List<Note> FindNotes(DateTime date)
        {
            List<Note> found = new List<Note>();
            foreach (Note note in notes)
            {
                if (note.DateTime.Date == date.Date)
                {
                    found.Add(note);
                }
            }
            return found;
        }

        public void PrintNotes(DateTime date, bool ShowText)
        {
            List<Note> notes = FindNotes(date);

            foreach (Note note in notes)
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" *");
                Console.ResetColor();
                Console.WriteLine(note.Name+ " " + note.DateTime );

                if(ShowText)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("    " + note.Text.Replace(@"\n", "\n    "));
                    Console.ResetColor();
                }
            }
        }

        public void PrintNotesList()
        {

            Console.Clear();
            Console.ResetColor();



            DateTime date = DateTime.Now.Date;
            ConsoleKey keyPressed;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                else if (keyPressed == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }

                Console.Clear();

                Console.WriteLine(date.ToString("dd'.'MM'.'yyyy"));

                List<Note> notesF = new List<Note>();

                notesF = FindNotes(date);
                if (notesF.Count() > 0)
                {
                    Console.WriteLine("Заметки найдены: ");
                    PrintNotes(date,false);
                        
                    keyInfo = Console.ReadKey();
                    keyPressed = keyInfo.Key;
                    if (keyPressed == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine(date.ToString("dd'.'MM'.'yyyy"));
                        Console.WriteLine("Заметки найдены: ");
                        PrintNotes(date, true);
                    }
                }
                else
                    Console.WriteLine("На это число нет заметок.");
            } while (keyPressed != ConsoleKey.Escape);

            Console.ResetColor();
            Console.Clear();

            noteMenu.Menu();
        }



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
                    AddNote();
                    break;
                case 1:
                    PrintNotesList();
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
}
