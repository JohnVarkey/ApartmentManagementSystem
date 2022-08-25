using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UtilityClass;
namespace FileManager
{

    interface IWriteManager
    {
        void writeApartmentData(string app_no, string line);
        void writeFamilyData(string ap_no, string line);
        void writeVehicleData(string Ap_no, string line);
        void writeVisitorData(string visitor_ID, string line);
        void updateVehicleState(string ap_no, List<string> lines);
        void updateVisitorState(string ap_no, List<string> lines);
        void updateApartmentState(string ap_no, List<string> lines);
    }
    class WriteManager
    {
        private List<IWriteManager> writers;
        private IWriteManager filewriter;
        private Utility U = new Utility();
        public WriteManager()
        {
            writers = new List<IWriteManager>();
            filewriter = new FileWriteManager();
            writers.Add(filewriter);
            U.initializeFileStructure();
        }
        public void writeApartmentData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeApartmentData(ap_no, line);
            });
        }
        public void writeVisitorData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeVisitorData(ap_no, line);
            });
        }
        public void writeVehicleData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeVehicleData(ap_no, line);
            });
        }
        
        public void writeFamilyData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeFamilyData(ap_no, line);
            });
        }
        public void updateVehicleState(string ap_no, List<string> lines)
        {
            writers.ForEach(writer =>
            {
                writer.updateVehicleState(ap_no, lines);
            });
        }
        public void updateApartmentState(string ap_no, List<string> lines)
        {
            writers.ForEach(writer =>
            {
                writer.updateApartmentState(ap_no, lines);
            });
        }
        public void updateVisitorState(string ap_no, List<string> lines)
        {
            writers.ForEach(writer =>
            {
                writer.updateVisitorState(ap_no, lines);
            });
        }
    }
    class FileWriteManager : IWriteManager
    {
        private string path { get; set; }
        public Utility utility { get; set; }
        public FileWriteManager()
        {
            utility = new Utility();
        }
        public void writeApartmentData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "AD");
            utility.writeToFilePath(path, line);
        }

        public void writeVisitorData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "RV");
            utility.writeToFilePath(path, line);
        }
        public void writeVehicleData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "VD");
            utility.writeToFilePath(path, line);
        }
        public void writeFamilyData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "FM");
            utility.writeToFilePath(path, line);
        }
        public void updateVehicleState(List<string> lines, string ap_no)
        {
            path = utility.getFilePath(ap_no, "VD");
            utility.updateToFilePath(path, lines);
        }
        public void updateApartmentState(string ap_no,List<string> lines)
        {
            path = utility.getFilePath(ap_no, "AD");
            utility.updateToFilePath(path, lines);
        }
        public void updateVisitorState(string ap_no, List<string> lines)
        {
            path = utility.getFilePath(ap_no, "RV");
            utility.updateToFilePath(path, lines);
        }

        public void updateVehicleState(string ap_no, List<string> lines)
        {
            path = utility.getFilePath(ap_no, "VD");
            utility.updateToFilePath(path, lines);
        }
    }

}