﻿using System;
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
        public Street street { get; set; }

        //Tag list with tag for specifk post
        public List<Tag> TagList => tagList;
        private List<Tag> tagList = new List<Tag>();

        /// <summary>
        /// Method for adding tag to cloud list
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(Tag tag)
        {
            tagList.Add(tag);
        }

        /// <summary>
        /// Method for find tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tag FindTag(Tag tag, string name) { tag = TagList.Find(x => x.Name == name); return tag; }
    }

    public class Tag
    {
        //Properties
        public string Name => name;
        public string Description => description;

        private string name;
        private string description;

        //Tag list with every tag
        public List<Tag> TagsList => tagList;
        private List<Tag> tagList = new List<Tag>();


        /// <summary>
        /// Constructor for making tags
        /// </summary>
        /// <param name="name_"></param>
        public Tag(string name_, string description_) 
        { 
            name = name_; 
            description = description_;
        }

        
        /// <summary>
        /// Read xml file and add to list
        /// </summary>
        public void Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);
            IEnumerable<XElement> tagXML = xdoc.Root.Descendants("Tag");

            foreach (XElement tagXml in tagXML)
            {
                string tagName = tagXml.Element("Name").Value;
                string tagDesc = tagXml.Element("Description").Value;

                tagList.Add(new Tag(tagName, tagDesc));

            }
        }


        /// <summary>
        /// Method for adding to list
        /// </summary>
        /// <param name="tag"></param>
        public void AddTag(Tag tag)
        {
            tagList.Add(tag);
        }


    }
}
