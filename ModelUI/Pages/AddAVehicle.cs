using CustomException;
using ModelUI.UIElements;
using Logger;
using System.Reflection;

namespace ModelUI.Pages
{
    public class AddVehiclePage : Page
    {
        public override string Header { get; set; } = "Add Vehicle";

        public override void Display()
        {
            base.DisplayHeader();
            try
            {
                new UIInputText($"Enter License Plate").Ask(out string lp);
                string[] vtype = new string[] { "2-wheeler", "3-wheeler", "4-wheeler" };

                new UICheckBox("Vehicle Type: ", vtype).Ask(out int type);
                
                new UIInputText($"Enter Vehicle Model").Ask(out string model);
                new UIInputText($"Enter Apartment Number").Ask(out string apt_no);
                UIHandler.Building.AddAVehicle(lp, vtype[type], model, true, apt_no);
                LogManager.Log(new CustomInfo($"Succefully Added Vehicle: {lp}, {vtype[type]}, {model}"));
                Console.WriteLine($"Succefully Added Vehicle: {lp}, {vtype[type]}, {model}");
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