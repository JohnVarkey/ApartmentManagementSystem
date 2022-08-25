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
       // public string paths { get; set; }
       // public string[] lines { get; set; }
      //  public string ap_no { get; set; }


        ValueObjectParser vp = new ValueObjectParser();
        IReader reader=new Reader();
        Utility U = new Utility();
        public FilereadManager()
        {
            //  this.paths = paths;
            //  this.lines = lines;
            Console.WriteLine("Read manager initialize");
            U.initializeFileStructure();


        }


        public List<APVO> readAllData()
        {



 
            return vp.convertAllDataFromFile(reader.ReadWholeFile(@"D:\building\data.txt"));



        }

        public List<RVVO> readVisitorData(string ap_no)
        {
            string path = U.getFilePath(ap_no, "RV");

            return vp.convertVisitorDataFromFile(U.readFromFilePath(path));
        }

        public List<ADVO> readApartMentData(string ap_no)
        {
            string path = U.getFilePath(ap_no, "AD");
            return vp.convertApartmentDataFromFile(U.readFromFilePath(path));

        }

        public List<VDVO> readVehicleData(string ap_no)
        {
            string path = U.getFilePath(ap_no, "VD");
            return vp.convertVehicleDataFromFile(U.readFromFilePath(path));
        }

        public List<FMVO> readMembers(string ap_no)
        {
            string path = U.getFilePath(ap_no,"FM");
            return vp.convertFamilyMemberDataFromFile(U.readFromFilePath(path));

        }


    }
}