using ModelUI.Pages;

namespace ModelUI
{
    public class program
    {
        public static void Main()
        {
            UIHandler.AddPage("homepage",new HomePage());
            UIHandler.AddPage("addapartment", new AddApartmentPage());
            UIHandler.AddPage("addfamilymember", new AddFamilyMemberPage());
            UIHandler.AddPage("addVehicle", new AddVehiclePage());
            UIHandler.AddPage("addVehicleStatus", new UpdateVehicleStatusPage());
            UIHandler.AddPage("removeRegularVisitor", new RemoveRegularVisitorPage());
            UIHandler.SetInitialPage("homepage");
            UIHandler.start();
        }
    }
}
