using ModelUI.UIElements;
using Logger;
using CustomException;

namespace ModelUI.Pages
{
    public class AddAVisitor: Page
    {
        public override string Header { get; set; } = "Add Visitor";

        public override void Display()
        {
            try
            {
                base.DisplayHeader();
                new UIInputText($"Enter Visitor Name").Ask(out string name);
                new UIInputText($"Enter Visitor ID").Ask(out int id);
                new UIInputText($"Enter Reason").Ask(out string reason);
                new UIInputText($"Enter Apartment ID").Ask(out string apt_no);
                UIHandler.Building.AddAVisitor(name, id, reason, apt_no);
                LogManager.Log(new CustomInfo($"Successfully Added a Visitor: {name}, {id}, {apt_no}, {reason}"));
                Console.WriteLine($"Successfully Added a Visitor: {name}, {id}, {apt_no}, {reason}\n\n Press a Key to Continue ... ");
            }catch(Exception err)
            {
                LogManager.Log(new CustomError(err.Message));
                Console.WriteLine($"Error :: {err.Message}");

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
