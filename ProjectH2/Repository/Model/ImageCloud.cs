using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    class ImageCloud
    {
        //ImageCloud Properity
        public Street Street { get; set; }
        public List<Image> ImList => image.ImageList;

        private Image image;


    }

    class Image : ImageCloud
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


        public Image(string name_, string description_, string path_, Street street)
        {
            name = name_;
            decscription = description_;
            path = path_;

            Street = street;
        }

        //Find image with name
        public Image FindImage(Image image, string name)
        {
            image = imageList.Find(x => x.name == name);
            return image;
        }
    }
}
