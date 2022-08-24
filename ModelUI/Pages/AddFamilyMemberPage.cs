using ModelUI.UIElements;
using Logger;
using CustomException;
namespace ModelUI.Pages
{ 
    public class AddFamilyMemberPage : Page
    {
        public override string Header { get; set; } = "Add Family Member";

        public override void Display()
        {
            base.DisplayHeader();
            try
            {
                new UIInputText($"Enter Apartment Number: ").Ask(out string apartmentnumber);
                new UIInputText($"Enter Member Name: ").Ask(out string membername);
                new UIInputText($"Enter Date of Birth: ").Ask(out string dob);
                new UIInputText($"Enter Relation to the Owner: ").Ask(out string relation);
                new UIInputText($"Enter Occupation: ").Ask(out string occupation);
                UIHandler.Building.AddFamilyMember(apartmentnumber, membername, dob, relation, occupation);
                Console.WriteLine($"Successfully Added : {apartmentnumber}, {membername}, {dob}, {relation}, {occupation}\n\n Press a Key to Continue ... ");
                Console.ReadKey();

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
