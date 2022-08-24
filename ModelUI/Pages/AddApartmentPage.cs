using ModelUI.UIElements;
using Logger;
using CustomException;

namespace ModelUI.Pages
{
    internal class AddApartmentPage : Page
    {
        public override string Header { get; set; } = "Add Apartment";

        public override void Display()
        {
            bool isOccupied = true;
            string name = String.Empty;
            try
            {
                base.DisplayHeader();
                new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
                try
                {
                    new UIInputText($"Enter Owner Name(if unoccupied press enter):-").Ask(out name);

                }
                catch (Exception)
                {
                    isOccupied = false;
                }
                string[] type = new string[] { "Studio", "2-BHK", "3-BHK" };

                new UICheckBox("Apartment Type", type).Ask(out int apartmenttype);

                UIHandler.Building.AddAppartment(apartmentnumber, name, type[apartmenttype], isOccupied);
                Console.WriteLine("\nSuccessfully Added\n\nPress a Key to Continue ... ");
            }
            
            catch (Exception err)
            {
                LogManager.Log(new CustomError(err.Message));


            }
            finally
            {
                Console.ReadKey();

                UIHandler.Pop();
            }

            return;
        }
    }
}
    
