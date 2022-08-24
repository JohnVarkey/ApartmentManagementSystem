using System;
using System.Collections.Generic;
using CustomException;
using ModelUI.UIElements;
using Logger;

namespace ModelUI.Pages
{
    internal class UpdateVehicleStatusPage : Page
    {
        public override string Header { get; set; } = "Update Vehicle Status";

        public override void Display()
        {
            string[] status = new string[] { "IN", "OUT" };
            try
            {
                base.DisplayHeader();
                new UIInputText($"Enter Apartment Number").Ask(out string apartmentnumber);
                new UIInputText($"Enter license plate number").Ask(out string lp);
                new UICheckBox("Enter the status of the vehicle", status).Ask(out int index);
                UIHandler.Building.UpdateVehicleStatus(lp, apartmentnumber, status[index]);
                LogManager.Log(new CustomInfo($"Successfully updated the vehicle status: {apartmentnumber}, {lp}, {status}"));
                Console.WriteLine($"Successfully updated the vehicle status: {apartmentnumber}, {lp}, {status} \n\n Press a Key to Continue ... ");
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
