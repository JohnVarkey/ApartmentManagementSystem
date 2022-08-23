using ModelUI.UIElements;

namespace ModelUI.Pages
{
    public class HomePage : Page {

        public override string Header { get; set; } = "Apartment Management System";

        public override void Display()
        {
            base.DisplayHeader();
            new UICheckBox("Reroute", new string[] { "Add Apartment", "Add Family Member", "Add Regular Visitor" }).Ask(out int reroute);
            if (reroute == 0)
            {
                UIHandler.Navigate("addapartment");
                return;
            }
        }
    }
}
