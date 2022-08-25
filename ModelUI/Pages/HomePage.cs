
using ModelUI.UIElements;
using ModelUI;
namespace ModelUI.Pages
{
    public class HomePage : Page {

        public override string Header { get; set; } = "Apartment Management System";    
        
        public override void Display()
        {
            base.DisplayHeader();
            new UICheckBox("Menu", new string[] { "Add Apartment", "Add Family Member", "Add Regular Visitor","Add a Vehicle","Update Vehicle Status","Remove a Regular Visitor", "Generate Report", "Exit" }).Ask(out int reroute);
            switch (reroute)
            {
                case 0:
                    UIHandler.Navigate("addapartment");
                    break;
               
                case 1:
                    UIHandler.Navigate("addfamilymember");
                    break;

                case 2:
                    UIHandler.Navigate("addRegularVisitor");
                    break;
                case 3:
                    UIHandler.Navigate("addVehicle");
                    break;
                case 4:
                    UIHandler.Navigate("addVehicleStatus");
                    break;
                case 5: UIHandler.Navigate("removeRegularVisitor");
                    break;
                case 6:
                    Console.Clear();
                    UIHandler.Building.GetReport();
                    Console.WriteLine("Press a Key to Continue ...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 7:
                    UIHandler.Pop();
                    break;
                default:
                    Console.WriteLine("\nInvalid Option");
                    break;
            }
            
        }
    }
}
