using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;
using System.Xml;

namespace ProjectH2.Repository.Model
{
    public class ImageCloud
    {
       //Properties
        public Street street { get; set; }
        public List<Image> ImageList => ImageList;

        private List<Image> imageList = new List<Image>();

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

        private string name;
        private string description;
        private string path;

       
        /// <summary>
        /// Constructor for adding an image
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="description_"></param>
        /// <param name="path_"></param>
        public Image(string name_, string description_, string path_) { name = name_; description = description_; path = path_; SaveText(); }

        /// <summary>
        /// Method for adding images to text file
        /// </summary>
        public void SaveText()
        {
            string path = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.xml";

            XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8);

            xmlTextWriter.Formatting = Formatting.Indented;

            xmlTextWriter.WriteStartDocument();

            xmlTextWriter.WriteComment("Test");

            xmlTextWriter.WriteStartElement("Tag");

            xmlTextWriter.WriteElementString("Name", Name);

            xmlTextWriter.WriteElementString("Description", Description);

            xmlTextWriter.WriteElementString("Path", Path);

            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteEndDocument();

            xmlTextWriter.Flush();

            xmlTextWriter.Close();

        }

    }
}
