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
            new UIInputText($"Enter Owner Name").Ask(out string name);
            new UICheckBox("Apartment Type", new string[] { "Studio", "2-BHK", "3-BHK" }).Ask(out int apartmenttype);

            Console.WriteLine($"Successfully Added : {apartmentnumber}, {apartmenttype}, {name}\n\n Press a Key to Continue ... ");
            Console.ReadKey();
            UIHandler.Pop();
            return;


        }
    }
}
