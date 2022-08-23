using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelUI.UIElements;

namespace ModelUI.Pages
{
    internal class RemoveRegularVisitorPage : Page
    {
        //void RemoveVisitor(string name, string apt_no);
        public override string Header { get; set; } = "Remove Regular Visitor";

        public override void Display()
        {

            base.DisplayHeader();
            new UIInputText($"Enter Visitor Name: ").Ask(out string visitorname);
            new UIInputText($"Enter Apartment Number: ").Ask(out string apartmentnumber);

            Console.WriteLine($"Successfully removed the visitor: {visitorname}, {apartmentnumber} \n\n Press a Key to Continue ... ");
            Console.ReadKey();
            UIHandler.Pop();
            return;

        }
    }
}
