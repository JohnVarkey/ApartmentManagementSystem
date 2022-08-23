using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelUI.UIElements;

namespace ModelUI.Pages
{
    internal class UpdateVehicleStatusPage : Page
    {
        public override string Header { get; set; } = "Update Vehicle Status";

        public override void Display()
        {
            base.DisplayHeader();
            new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
            new UIInputText($"Enter liscense plate number").Ask(out string lp);
            new UICheckBox("Enter the status of the vehicle", new string[] { "IN", "OUT" }).Ask(out int status);

            Console.WriteLine($"Successfully updated the vehicle status: {apartmentnumber}, {lp}, {status} \n\n Press a Key to Continue ... ");
            Console.ReadKey();
            UIHandler.Pop();
            return;


        }
    }
}
