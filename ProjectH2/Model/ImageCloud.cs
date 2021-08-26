﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Controller;
using System.Xml;
using System.Xml.Linq;

namespace ProjectH2.Model
{
    public class ImageCloud
    {
       //Properties
        public Street street { get; set; }
        public List<Image> ImageList => image.ImageList;

        private Image image;
        
        /// <summary>
        /// Method for finding images based on there name
        /// </summary>
        /// <param name="image"></param>
        /// <param name="name_"></param>
        /// <returns></returns>
        public Image FindImage(Image image, string name_) { image = ImageList.Find(x => x.Name == name_); return image; }
    }


    public class Image
    {
        //Properties
        public string Name => name;
        public string Description => description;
        public string Path => path;
        public List<Image> ImageList => imageList;

        private string name;
        private string description;
        private string path;

        private List<Image> imageList = new List<Image>();

       
        /// <summary>
        /// Constructor for adding an image
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="description_"></param>
        /// <param name="path_"></param>
        public Image(string name_, string description_, string path_) 
        { 
            name = name_; 
            description = description_; 
            path = path_; 
        
        }

        /// <summary>
        /// Read xml file and add to list
        /// </summary>
        public void Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);
            IEnumerable<XElement> imageXML = xdoc.Root.Descendants("Tag");

            foreach (var imagXml in imageXML)
            {
                string imageName = imagXml.Element("Name").Value;
                string imageDesc = imagXml.Element("Description").Value;
                string imagePath = imagXml.Element("Path").Value;

                imageList.Add(new Image(imageName, imageDesc, imagePath));

            }
        }


    }
}