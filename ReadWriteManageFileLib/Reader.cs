using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class Reader : IReader
    {


        public List<List<string>> ReadWholeFile(string path)
        {
            if (File.Exists(path)==false)
            {
                throw new Exception("For reading whole file does not found at this location " + path);

            }
            string[] lines = File.ReadAllLines(path);
            List<string> tempList = new List<string>();
            int count = 0;
            List<List<string>> list = new List<List<string>>();

            foreach (string line in lines)
            {
                string[] tuple = line.Split(',');

                if (tuple[0] == "AD")
                {
                    if (count == 1)
                    {
                        list.Add(new List<string>(tempList));
                        tempList = new List<string>(); // also resetting the list for another reference with another memory location
                        count = 0;
                    }

                    tempList.Add(line);
                    count++;

                }
                else 
                    tempList.Add(line);
            }


            return list;

        }

    }

}
