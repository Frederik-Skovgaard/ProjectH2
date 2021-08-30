using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProjectH2.Repository
{
    class EntryRepo
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

        public void EntryDelete(int identification)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";
            XDocument doc = XDocument.Load(line);

            //Foreach entry take higest id
            IEnumerable<XElement> elemList = doc.Root.Descendants("BlogPost").
                Where(o => o.Attribute("ID").Value == identification.ToString() && !o.HasAttributes);
                
            foreach (XElement item in elemList)
            {
                
            }
            elemList = doc.Root.Descendants("FrameworkReview");
            foreach (XElement item in elemList)
            {
                
            }
            elemList = doc.Root.Descendants("Reference");
            foreach (XElement item in elemList)
            {
                
            }
        }
    }
}
