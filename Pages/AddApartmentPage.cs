using ModelUI.UIElements;


namespace ModelUI.Pages
{
    internal class AddApartmentPage : Page
    {
        public override string Header { get; set; } = "Add Apartment";

        public override void Display()
        {

            base.DisplayHeader();
            new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
            bool isOccupied = true;

            new UIInputText($"Enter Owner Name(if unoccupied press enter):-").Ask(out string name);
            if(name.Length == 0) isOccupied = false;
            string[] type = new string[] { "Studio", "2-BHK", "3-BHK" };

            new UICheckBox("Apartment Type",type ).Ask(out int apartmenttype);

            Console.WriteLine($"Successfully Added : {apartmentnumber}, {type[apartmenttype]}, {name}, {isOccupied}\n\nPress a Key to Continue ... ");
            Console.ReadKey();
            UIHandler.Pop();
            return;
        }
    }
}
    
