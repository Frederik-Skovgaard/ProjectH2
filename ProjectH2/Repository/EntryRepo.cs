using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProjectH2.Repository
{

    public class EntryRepo
    {
        public int ID => id;
        private int id;


        /// <summary>
        /// Method for getting highest ID
        /// </summary>
        public void IDCatcher()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";
            XDocument doc = XDocument.Load(line);
            

            //Max ID list
            List<int> idList = new List<int>();

            //Foreach entry take higest id
            IEnumerable<XElement> elemList = doc.Root.Descendants("BlogPost");
            foreach (XElement item in elemList)
            {
                idList.Add((int)item.Attributes("ID").Max());
            }
            elemList = doc.Root.Descendants("FrameworkReview");
            foreach (XElement item in elemList)
            {
                idList.Add((int)item.Attributes("ID").Max());
            }
            elemList = doc.Root.Descendants("Reference");
            foreach (XElement item in elemList)
            {
                idList.Add((int)item.Attributes("ID").Max());
            }

            //If ID dosen't exists
            if (idList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = idList.Max() + 1;
            }
            
        }

        /// <summary>
        /// Method for deleting entry
        /// </summary>
        /// <param name="identification"></param>
        public void EntryDelete(int identification)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);

            XElement entry = xdoc.Root.Elements("BlogPost")
                .FirstOrDefault(w => (int)w.Attribute("ID") == identification);

            if (entry != null)
            {
                entry.Element("Active").Value = "False";
               
                xdoc.Save(line);
            }
            else
            {
                Console.WriteLine("Entry dosen't exists...");
                xdoc.Save(line);
            }
        }


        /// <summary>
        /// Method for updating
        /// </summary>
        /// <param name="identification"></param>
        public void EntryUpdate(int identification, string element, string input)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);

            XElement entry = xdoc.Root.Elements("BlogPost")
                .FirstOrDefault(w => (int)w.Attribute("ID") == identification);

            if (entry != null)
            {
                entry.Element(element).Value = input;
                xdoc.Save(line);
            }
            else
            {
                xdoc.Save(line);
            }
        }
    }
}
