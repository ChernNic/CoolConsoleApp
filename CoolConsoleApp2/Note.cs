using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolConsoleApp2
{
    internal class Note
    {
        public DateTime DateTime;
        public string Name;
        public string Text;

        public Note(DateTime dateTime, string name, string text)
        {
            DateTime = dateTime;
            Name = name;
            Text = text;
        }
    }
}
