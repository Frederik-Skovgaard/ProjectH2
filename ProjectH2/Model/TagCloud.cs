using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ProjectH2.Controller;

namespace ProjectH2.Model
{
    
    public class TagCloud
    {
        //Properties
        //TODO: Maybe change
        public Street street { get; set; }
        //public List<Tag> TagsList => tag.TagList;

        private Tag tag;

        //Read & Add to list
        public void Read()
        {
            tag.Reader();
        }

        /// <summary>
        /// Method for find tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        //public Tag FindTag(string name) { tag = TagsList.Find(x => x.Name == name); return tag; }
    }

    public class Tag
    {
        //Properties
        public string Name => name;
        public string Description => description;
        public List<Tag> TagList => tagList;

        private string name;
        private string description;
        private List<Tag> tagList = new List<Tag>();

        /// <summary>
        /// Constructor for making tags
        /// </summary>
        /// <param name="name_"></param>
        public Tag(string name_, string description_) 
        { 
            name = name_; 
            description = description_; 

            tagList.Add(new Tag(name_, description_));
        }

        //Read xml file and add to list
        public void Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);
            IEnumerable<XElement> tagXML = xdoc.Root.Descendants("Tag");

            foreach (var tagXml in tagXML)
            {
                string tagName = tagXml.Element("Name").Value;
                string tagDesc = tagXml.Element("Description").Value;

                tagList.Add(new Tag(tagName, tagDesc));
                
            }

        }


    }
}
