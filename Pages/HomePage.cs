
using ModelUI.UIElements;

namespace ModelUI.Pages
{
    public class HomePage : Page {

        public override string Header { get; set; } = "Apartment Management System";

        public override void Display()
        {
            base.DisplayHeader();
            new UICheckBox("Menu", new string[] { "Add Apartment", "Add Family Member", "Add Regular Visitor","Add a Vehicle","Update Vehicle Status","Remove a Regular Visitor" }).Ask(out int reroute);
            switch (reroute)
            {
                case 0:
                    UIHandler.Navigate("homepage");
                    break;
               
                case 1:
                    UIHandler.Navigate("addapartment");
                    break;

                case 2:
                    UIHandler.Navigate("addfamilymember");
                    break;
                case 3:
                    UIHandler.Navigate("addVehicle");
                    break;
                case 4:
                    UIHandler.Navigate("addVehicleStatus");
                    break;
                case 5: UIHandler.Navigate("removeRegularVisitor");
                    break;
                default: 
                    break;
            }
            
        }
    }
}
