using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Midi;

namespace CoolConsoleApp2
{
    class Piano
    {
        public void Run()
        {
            Console.Clear();
            Graphic _Graphic = new Graphic();
            Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");

            ConsoleKey keyPressed;
            MidiOut midiOut = new MidiOut(0);
            //                             C   C#  D   D#  E   F   F#  G   G#  A   A#  B
            //                             0   1   2   3   4   5   6   7   8   9   10  11
            int[] NotesFrenq = new int[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            int Note;
            int Octave = 2;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                switch (keyPressed)
                {
                    case ConsoleKey.Tab: //С OCTAVE - 1
                        Note = NotesFrenq[0] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D1: //С# OCTAVE - 1
                        Note = NotesFrenq[1] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.Q: //D OCTAVE - 1
                        Note = NotesFrenq[2] + (12 * ( Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D2: //D# OCTAVE - 1
                        Note = NotesFrenq[3] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.W: //E OCTAVE - 1
                        Note = NotesFrenq[4] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.E: //F OCTAVE - 1
                        Note = NotesFrenq[5] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D4: //F# OCTAVE - 1
                        Note = NotesFrenq[6] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.R: //G OCTAVE - 1
                        Note = NotesFrenq[7] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D5: //G# OCTAVE - 1
                        Note = NotesFrenq[8] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.T: //A OCTAVE - 1
                        Note = NotesFrenq[9] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D6: //A# OCTAVE - 1
                        Note = NotesFrenq[10] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.Y: //B OCTAVE - 1
                        Note = NotesFrenq[11] + (12 * (Octave - 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;

                    case ConsoleKey.U: //С
                        Note = NotesFrenq[0] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D8: //С#
                        Note = NotesFrenq[1] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.I: //D 
                        Note = NotesFrenq[2] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.D9: //D# 
                        Note = NotesFrenq[3] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.O: //E 
                        Note = NotesFrenq[4] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.P: //F
                        Note = NotesFrenq[5] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case ConsoleKey.OemMinus: //F#
                        Note = NotesFrenq[6] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                }
            } while (keyPressed != ConsoleKey.Escape);

            Console.ResetColor();
            Console.Clear();
            _Graphic.ProgramLogo();

            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();
        }
    }
}

