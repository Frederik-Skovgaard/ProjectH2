using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProjectH2.Model
{
    public class ImageCloud
    {
       //Properties
        public Street Streets { get; set; }

        //Image list with images for specifk post
        public List<Image> ImageList => imageList;
        private List<Image> imageList = new List<Image>();

        /// <summary>
        /// Method for adding image to list
        /// </summary>
        /// <param name="ima"></param>
        public void AddImage(Image ima)
        {
            imageList.Add(ima);
        }


        /// <summary>
        /// Method for finding images based on there name
        /// </summary>
        /// <param name="image"></param>
        /// <param name="name_"></param>
        /// <returns></returns>
        public Image FindImage(Image image, string name_) { image = ImageList.Find(x => x.Name == name_); return image; }

        /// <summary>
        /// Constructer for street
        /// </summary>
        /// <param name="street"></param>
        public ImageCloud(Street street)
        {
            Streets = street;
        }

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

        //Image list with every image
        public List<Image> ImageList => imageList;
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
        public async Task Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = await LoadAsync(line);

            //List of all tags
            IEnumerable<XElement> blog = xdoc.Root.Descendants("BlogPost");
            IEnumerable<XElement> fram = xdoc.Root.Descendants("FrameworkReview");
            IEnumerable<XElement> refe = xdoc.Root.Descendants("Reference");


            //Foreach image in Blog post
            foreach (XElement imagXml in blog)
            {
                if (imagXml.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = imagXml.Descendants("Image");
                    foreach (XElement xe in x)
                    {
                        string imageName = xe.Element("ImageName").Value;
                        string imageDesc = xe.Element("ImageDescription").Value;
                        string imagePath = xe.Element("ImagePath").Value;

                        imageList.Add(new Image(imageName, imageDesc, imagePath));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }

            //Foreach image in Framework review
            foreach (XElement imagXml in fram)
            {
                if (imagXml.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = imagXml.Descendants("Image");
                    foreach (XElement xe in x)
                    {
                        string imageName = xe.Element("ImageName").Value;
                        string imageDesc = xe.Element("ImageDescription").Value;
                        string imagePath = xe.Element("ImagePath").Value;

                        imageList.Add(new Image(imageName, imageDesc, imagePath));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }

            //Foreach image in Reference
            foreach (XElement imagXml in refe)
            {
                if (imagXml.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = imagXml.Descendants("Image");
                    foreach (XElement xe in x)
                    {
                        string imageName = xe.Element("ImageName").Value;
                        string imageDesc = xe.Element("ImageDescription").Value;
                        string imagePath = xe.Element("ImagePath").Value;

                        imageList.Add(new Image(imageName, imageDesc, imagePath));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }
        }


        /// <summary>
        /// Asyncly read xml file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Task<XDocument> LoadAsync(String path)
        {
            return Task.Run(() =>
            {
                using (var stream = File.OpenText(path))
                {
                    return XDocument.Load(stream);
                }
            });
        }

        /// <summary>
        /// Method for adding image to list
        /// </summary>
        /// <param name="ima"></param>
        public void AddImage(Image ima)
        {
            imageList.Add(ima);
        }
    }
}
