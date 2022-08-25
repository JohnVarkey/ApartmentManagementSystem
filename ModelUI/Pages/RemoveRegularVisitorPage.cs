using CustomException;
using ModelUI.UIElements;
using Logger;

namespace ModelUI.Pages
{
    internal class RemoveRegularVisitorPage : Page
    {
        //void RemoveVisitor(string name, string apt_no);
        public override string Header { get; set; } = "Remove Regular Visitor";

        public override void Display()
        {
            try
            {

                base.DisplayHeader();
                new UIInputText($"Enter Visitor Name").Ask(out string visitorname);
                new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
                LogManager.Log(new CustomInfo($"Successfully removed the visitor: {visitorname}, {apartmentnumber}"));
                Console.WriteLine($"Successfully removed the visitor: {visitorname}, {apartmentnumber} \n\n Press a Key to Continue ... ");
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
