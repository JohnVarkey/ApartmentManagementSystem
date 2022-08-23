using ModelUI.Pages;

namespace ModelUI
{
    public class program
    {
        public static void Main()
        {
            UIHandler.AddPage("homepage",new HomePage());
            UIHandler.AddPage("addapartment", new AddApartmentPage());
            UIHandler.SetInitialPage("homepage");
            UIHandler.start();
        }
    }
}
