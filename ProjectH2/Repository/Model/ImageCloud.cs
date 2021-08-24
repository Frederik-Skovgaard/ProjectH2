using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    
    public class ImageCloud
    {
        //ImageCloud Properity
        public Street Street { get; set; }
        public List<Image> ImList => image.ImageList;

        private Image image;


        /// <summary>
        /// Method for ading images
        /// </summary>
        /// <param name="image"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Image FindImage(Image image, string name) { image = ImList.Find(x => x.Name == name); return image; }
    }

    public class Image : ImageCloud
    {
        //Image properties
        public string Name => name;
        public string Description => decscription;
        public string Path => path;

        private string name;
        private string decscription;
        private string path;

        public List<Image> ImageList => imageList;
        private List<Image> imageList;

        /// <summary>
        /// Contrutor for adding images to entry
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="description_"></param>
        /// <param name="path_"></param>
        /// <param name="stree"></param>
        public Image(string name_, string description_, string path_, Street stree) 
        { 
            name = name_; 
            decscription = description_;
            path = path_; 
            Street = stree; 
            
            imageList.Add(new Image(name_, description_, path_, stree)); 
        }

        
    }
}
