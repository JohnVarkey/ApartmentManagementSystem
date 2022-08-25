using FileManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClass;

namespace FileManager
{
    internal class FilereadManager : IFileReadManager
    {

        string initalfilepath = String.Empty;
        ValueObjectParser vp = new ValueObjectParser();
        IReader reader=new Reader();
        Utility utility;
        public FilereadManager(string initalFilePath)
        {
            utility = new Utility(initalFilePath);
            this.initalfilepath = initalFilePath;
            Console.WriteLine("Read manager initialize");
            utility.initializeFileStructure();


        }


        public List<APVO> readAllData()
        {
            return vp.convertAllDataFromFile(reader.ReadWholeFile(initalfilepath));
        }

        public List<RVVO> readVisitorData(string ap_no)
        {
            string path = utility.getFilePath(ap_no, "RV");

            return vp.convertVisitorDataFromFile(utility.readFromFilePath(path));
        }

        public List<ADVO> readApartMentData(string ap_no)
        {
            string path = utility.getFilePath(ap_no, "AD");
            return vp.convertApartmentDataFromFile(utility.readFromFilePath(path));

        }

        public List<VDVO> readVehicleData(string ap_no)
        {
            string path = utility.getFilePath(ap_no, "VD");
            return vp.convertVehicleDataFromFile(utility.readFromFilePath(path));
        }

        public List<FMVO> readMembers(string ap_no)
        {
            string path = utility.getFilePath(ap_no,"FM");
            return vp.convertFamilyMemberDataFromFile(utility.readFromFilePath(path));

        }


    }
}