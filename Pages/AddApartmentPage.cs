using ModelUI.UIElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelUI.Pages
{
    internal class AddApartmentPage : Page
    {
        public override string Header { get; set; } = "Add Apartment";

        public override void Display()
        {
            base.DisplayHeader();
            new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
            new UIInputText($"Enter Owner Name").Ask(out string name);
            new UICheckBox("Apartment Type", new string[] { "Studio", "2-BHK", "3-BHK" }).Ask(out int apartmenttype);

            Console.WriteLine($"{apartmentnumber}, {apartmenttype}, {name}");
            Console.ReadKey();


        }
    }
}
