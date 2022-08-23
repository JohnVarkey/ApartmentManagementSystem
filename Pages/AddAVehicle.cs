using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelUI.UIElements;

namespace ModelUI.Pages
{
    public class AddVehiclePage : Page
    {
        public override string Header { get; set; } = "Add Vehicle";

        public override void Display()
        {
            base.DisplayHeader();
            new UIInputText($"Enter License Plate").Ask(out string lp);
            string[] vtype = new string[] { "2-wheeler", "3-wheeler", "4-wheeler" };

            new UICheckBox("Vehicle Type: ", vtype).Ask(out int type);
            new UIInputText($"Enter Vehicle Model").Ask(out string model);
            bool[] status = { false, true };
            new UICheckBox("Enter vehicle status", new string[] { "OUT", "IN" }).Ask(out int isin);
            new UIInputText($"Enter Apartment Number").Ask(out string apt_no);
            Console.WriteLine($"Succefully Added Vehicle: {lp}, {vtype[type]}, {model}, {status[isin]},{apt_no}");
           
            Console.ReadKey();
            UIHandler.Pop();
            return;


        }
    }
}