using System;
using System.Threading;
using NAudio.Midi;

namespace CoolConsoleApp2
{
    class Piano
    {
        public void Run()
        {
            Console.Clear();
            Graphic _Graphic = new Graphic();

            int keyPressed;
            MidiOut midiOut = new MidiOut(0);
            //                             C   C#  D   D#  E   F   F#  G   G#  A   A#  B
            //                             0   1   2   3   4   5   6   7   8   9   10  11
            int[] NotesFrenq = new int[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            int Note;
            int Octave = 1;
            int SelectedKey = 1;

            do
            {
                new Thread(DisplayPiano).Start();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = Convert.ToInt32(keyInfo.Key);

                switch (keyPressed)
                {
                    case 9: //С 
                        Note = NotesFrenq[0] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 0;
                        break;
                    case 49: //С# 
                        Note = NotesFrenq[1] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 1;
                        break;
                    case 81: //D 
                        Note = NotesFrenq[2] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 2;
                        break;
                    case 50: //D#
                        Note = NotesFrenq[3] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 3;
                        break;
                    case 87: //E
                        Note = NotesFrenq[4] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 4;
                        break;
                    case 69: //F 
                        Note = NotesFrenq[5] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 5;
                        break;
                    case 52: //F#
                        Note = NotesFrenq[6] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 6;
                        break;
                    case 82: //G 
                        Note = NotesFrenq[7] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 7;
                        break;
                    case 53: //G#
                        Note = NotesFrenq[8] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 8;
                        break;
                    case 84: //A 
                        Note = NotesFrenq[9] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 9;
                        break;
                    case 54: //A# 
                        Note = NotesFrenq[10] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 10;
                        break;
                    case 89: //B
                        Note = NotesFrenq[11] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 12;
                        break;

                    case 85: //С
                        Note = NotesFrenq[0] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 13;
                        break;
                    case 56: //С#
                        Note = NotesFrenq[1] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 14;
                        break;
                    case 73: //D 
                        Note = NotesFrenq[2] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 15;
                        break;
                    case 57: //D# 
                        Note = NotesFrenq[3] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 16;
                        break;
                    case 79: //E 
                        Note = NotesFrenq[4] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 17;
                        break;
                    case 80: //F
                        Note = NotesFrenq[5] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 18;
                        break;
                    case 189: //F#
                        Note = NotesFrenq[6] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 19;
                        break;
                    case 26: //G 
                        Note = NotesFrenq[7] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 20;
                        break;
                    case 186: //G#
                        Note = NotesFrenq[8] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 21;
                        break;
                    case 27: //A 
                        Note = NotesFrenq[9] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 22;
                        break;
                    case 14: //A# 
                        Note = NotesFrenq[10] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 23;
                        break;
                    case 220: //B
                        Note = NotesFrenq[11] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 24;
                        break;
                    case 13: //B
                        Note = NotesFrenq[11] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        SelectedKey = 25;
                        break;

                    case 112:
                        Octave--;
                        if (Octave <= 0) Octave = 7;
                        break;
                    case 113:
                        Octave++;
                        if (Octave >= 8) Octave = 1;
                        break;
                }
            } while (keyPressed != 27);

            Console.ResetColor();
            Console.Clear();
            _Graphic.ProgramLogo();

            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();

            void DisplayPiano() 
            {
                Console.Clear();
                Console.WriteLine("Чтобы вернуться в главное меню нажмите ESC.\n");
                Console.WriteLine($"Октавы: {Octave} и {Octave + 1}");
                
            }

        }
    }
}


