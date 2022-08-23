using ModelUI.UIElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelUI.Pages
{ 
    internal class AddFamilyMemberPage : Page
    {
        public override string Header { get; set; } = "Add Family Member";

        public override void Display()
        {
            base.DisplayHeader();
            new UIInputText($"Enter Apartment Number: ").Ask(out string apartmentnumber);
            new UIInputText($"Enter Member Name: ").Ask(out string membername);
            new UIInputText($"Enter Date of Birth: ").Ask(out string dob);
            new UIInputText($"Enter Relation to the Owner: ").Ask(out string relation);
            new UIInputText($"Enter Occupation: ").Ask(out string occupation);

            Console.WriteLine($"Successfully Added : {apartmentnumber}, {membername}, {dob}, {relation}, {occupation}\n\n Press a Key to Continue ... ");
            Console.ReadKey();
            UIHandler.Pop();
            return;

        }
    }
}
