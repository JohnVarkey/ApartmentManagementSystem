using ModelUI.Pages;
using CircleStack;
using Logger;
using CustomException;

namespace ModelUI
{
    public class Program
    {
        public static string initialdatafilepath = "../../../data.txt";
        static Building Condoor = new Building("Condoor", 20, initialdatafilepath);
        static string filepath = "Logs.txt";
        public static void Main()
        {
            //try
            //{
                if (!File.Exists(filepath))
                {
                    File.Create(filepath);
                }
                BuildingInit(initialdatafilepath);
                LoggerInit();
                UIInit();
                UIHandler.SetInitialPage("homepage");
                UIHandler.start();
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    LogManager.Log(new CustomError(ex.Message));
            //}
           
            
           
        }

        private static void LoggerInit()
        {
            
            LogManager.AddLogger(new FileLogger(filepath));
        }

        private static void UIInit()
        {
            UIHandler.Building = Condoor;
            UIHandler.AddPage("homepage", new HomePage());
            UIHandler.AddPage("addapartment", new AddApartmentPage());
            UIHandler.AddPage("addfamilymember", new AddFamilyMemberPage());
            UIHandler.AddPage("addVehicle", new AddVehiclePage());
            UIHandler.AddPage("addVehicleStatus", new UpdateVehicleStatusPage());
            UIHandler.AddPage("addRegularVisitor", new AddAVisitor());
            UIHandler.AddPage("removeRegularVisitor", new RemoveRegularVisitorPage());
        }


        private static void BuildingInit(string initialfilepath)
        {

            
                var values = File.ReadAllLines(initialfilepath);
                string cur_apt = "";
                foreach (string i in values)
                {
                    var fields = i.Split(",");
                    switch (fields[0])
                    {
                        case "AD":
                            if (fields[2].Equals("UNOCCUPIED"))
                            {
                                Condoor.AddAppartment(fields[1], fields[2], fields[3], false);
                            }
                            else
                            {
                                cur_apt = fields[1];
                                //Console.WriteLine(cur_apt);
                                Condoor.AddAppartment(fields[1], fields[2], fields[3], true);
                            }
                            break;

                        case "FM":
                            Condoor.AddFamilyMember(cur_apt, fields[1], fields[3], fields[4], fields[2]);
                            break;

                        case "VD":
                            if (fields[4].Equals("IN"))
                            {
                                Condoor.AddAVehicle(fields[1], fields[2], fields[3], true, cur_apt);
                            }
                            else
                            {
                                Condoor.AddAVehicle(fields[1], fields[2], fields[3], false, cur_apt);
                            }
                            break;

                        case "RV":
                            Condoor.AddAVisitor(fields[2], Convert.ToInt32(fields[1]), fields[3], cur_apt);
                            break;
                    }
                }
                Console.WriteLine("\nxxxxxxxx Transfer Succesfull xxxxxxxxxx");
                Condoor.GetReport();
            
           
        }
    }
}
