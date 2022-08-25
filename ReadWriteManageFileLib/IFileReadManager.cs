using FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IFileReadManager
    {
       
        public List<APVO> readAllData();
        public List<RVVO> readVisitorData(string ap_no);
        public List<ADVO> readApartMentData(string ap_no);
        public List<VDVO> readVehicleData(string ap_no);
        public List<FMVO> readMembers(string ap_no);
    }
}
