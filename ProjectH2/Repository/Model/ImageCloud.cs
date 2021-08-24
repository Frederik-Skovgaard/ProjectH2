using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    public class ImageCloud
    {
        public Street street { get; set; }
        public List<Image> ImageList => ImageList;

        private List<Image> imageList;

        public Image FindImage(Image image, string name_) { image = ImageList.Find(x => x.Name == name_); return image; }
    }


    public class Image
    {
        public string Name => name;
        public string Description => description;
        public string Path => path;

        private string name;
        private string description;
        private string path;

       

        public Image(string name_, string description_, string path_)
        {
            name = name_;
            description = description_;
            path = path_;

            SaveText();
        }

        /// <summary>
        /// Method for adding images to text file
        /// </summary>
        public void SaveText()
        {
            string path = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.txt";

            using (TextWriter tw = new StreamWriter(path, true))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    tw.WriteLine($"{name},{Path} (Image)");
                }
                else
                {
                    tw.WriteLine($"{name},{Path} (Image)");
                }
            }
        }

    }
}
