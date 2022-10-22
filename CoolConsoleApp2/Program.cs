namespace CoolConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphic _Graphic = new Graphic();
            _Graphic.ProgramLogoStart();
            Notepad notepad = new Notepad();
            notepad.NoteDeff();
            KeyboardMenu mainMenu = new KeyboardMenu();
            mainMenu.MainMenu();

        }
    }
}
