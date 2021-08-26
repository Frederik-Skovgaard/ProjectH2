using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Controller;
using System.Xml;

namespace ProjectH2.Model
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
        public Image(string name_, string description_, string path_) { name = name_; description = description_; path = path_; }

    }
}
