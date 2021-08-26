using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProjectH2.Controller;
using ProjectH2.Model;

namespace ProjectH2.Repository
{

    class EntryRepo
    {
        /// <summary>
        /// Method for adding tags to text file
        /// </summary>
        public void SaveText(BlogPost blog, Image image, Files file, Language language, Tag tag, Street street)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Entry
            XmlNode nodeEntry = xdoc1.CreateElement("Entry");
            xdoc1.DocumentElement.AppendChild(nodeEntry);

            //Blog Post
            XmlNode nodeBlog = xdoc1.CreateElement("BlogPost");
            nodeEntry.AppendChild(nodeBlog);

            XmlNode nodeHeadLine = xdoc1.CreateElement("HeadLine");
            nodeHeadLine.InnerText = blog.HeadLine;
            nodeBlog.AppendChild(nodeHeadLine);

            XmlNode nodeText = xdoc1.CreateElement("Text");
            nodeText.InnerText = blog.Text;
            nodeBlog.AppendChild(nodeText);

            XmlNode nodeStartDate = xdoc1.CreateElement("StartDate");
            nodeStartDate.InnerText = blog.StartDate.ToString();
            nodeBlog.AppendChild(nodeStartDate);

            XmlNode nodeEndDate = xdoc1.CreateElement("EndDate");
            nodeEndDate.InnerText = blog.EndDate.ToString();
            nodeBlog.AppendChild(nodeEndDate);

            XmlNode nodeFileCloud = xdoc1.CreateElement("FileCloud");
            nodeBlog.AppendChild(nodeFileCloud);

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeBlog.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeBlog.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeBlog.AppendChild(nodeLanguageCloud);

            XmlNode nodeActive = xdoc1.CreateElement("Active");
            nodeActive.InnerText = blog.Active.ToString();
            nodeBlog.AppendChild(nodeActive);

            //File

            XmlNode nodeFile = xdoc1.CreateElement("File");
            nodeFileCloud.AppendChild(nodeFile);

            XmlNode nodeFileName = xdoc1.CreateElement("Name");
            nodeFileName.InnerText = file.Name;
            nodeFile.AppendChild(nodeFileName);

            XmlNode nodeFileLanguage = xdoc1.CreateElement("FileLanguage");
            nodeFileLanguage.InnerText = file.Language;
            nodeFile.AppendChild(nodeFileLanguage);

            XmlNode nodeFilePath = xdoc1.CreateElement("FilePath");
            nodeFilePath.InnerText = file.Path;
            nodeFile.AppendChild(nodeFilePath);





            //Image
            XmlNode nodeImage = xdoc1.CreateElement("Image");
            nodeImageCloud.AppendChild(nodeImage);

            XmlNode nodeImageName = xdoc1.CreateElement("Name");
            nodeImageName.InnerText = image.Name;
            nodeImage.AppendChild(nodeImageName);

            XmlNode nodeImageDescription = xdoc1.CreateElement("Description");
            nodeImageDescription.InnerText = image.Description;
            nodeImage.AppendChild(nodeImageDescription);

            XmlNode nodeImagePath = xdoc1.CreateElement("Path");
            nodeImagePath.InnerText = image.Path;
            nodeImage.AppendChild(nodeImagePath);



            //Tag 
            XmlNode nodeTag = xdoc1.CreateElement("Tag");
            nodeTagCloud.AppendChild(nodeTag);

            XmlNode nodeName = xdoc1.CreateElement("Name");
            nodeName.InnerText = tag.Name;
            nodeTag.AppendChild(nodeName);

            XmlNode nodeDescription = xdoc1.CreateElement("Description");
            nodeDescription.InnerText = tag.Description;
            nodeTag.AppendChild(nodeDescription);

            //Language
            XmlNode nodeLanguage = xdoc1.CreateElement("Language");
            nodeLanguageCloud.AppendChild(nodeLanguage);

            XmlNode nodeLanguageName = xdoc1.CreateElement("Name");
            nodeLanguageName.InnerText = language.Name;
            nodeLanguage.AppendChild(nodeLanguageName);


            xdoc1.Save(line);

        }
    }
}
