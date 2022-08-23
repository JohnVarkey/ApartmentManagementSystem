using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelUI.Pages
{
    public abstract class Page : IPage
    {
        public abstract string Header { get; set; }

        public void DisplayHeader()
        {
            Console.Write(new string(' ', (Console.WindowWidth - Header.Length) / 2));
            Console.WriteLine(Header);

        }

        public abstract void Display();
    }
}
