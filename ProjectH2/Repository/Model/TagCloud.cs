using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    
    public class TagCloud
    {
        //Properties
        //TODO: Maybe change
        public Street street { get; set; }
        public List<Tag> TagsList => tagList;
        private List<Tag> tagList = new List<Tag>();
      
        private Tag tag;

        public void Reader()
        {
            string path = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.Xml";

            XmlTextReader xtr = new XmlTextReader(path);
            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Description")
                {
                    string s1 = xtr.ReadString();
                    Console.WriteLine($"Tag = {s1}" );
                }
            }

        }

        /// <summary>
        /// Method for find tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tag FindTag(string name) { tag = TagsList.Find(x => x.Name == name); return tag; }
    }

    public class Tag
    {
        //Properties
        public string Name => name;
        public string Description => description;

        private string name;
        private string description;

        /// <summary>
        /// Constructor for making tags
        /// </summary>
        /// <param name="name_"></param>
        public Tag(string name_, string description_) { name = name_; description = description_; }

        /// <summary>
        /// Method for adding tags to text file
        /// </summary>
        public void SaveText(Tag tag)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.xml";

            XmlTextWriter xmlTextWriter = new XmlTextWriter(line, Encoding.UTF8);

            xmlTextWriter.Formatting = Formatting.Indented;

            xmlTextWriter.WriteStartDocument();

            xmlTextWriter.WriteComment("Test");

            xmlTextWriter.WriteStartElement("Tag");

            xmlTextWriter.WriteElementString("Name", Name);

            xmlTextWriter.WriteElementString("Description", Description);

            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteEndDocument();

            xmlTextWriter.Flush();

            xmlTextWriter.Close();
        }

    }
}
