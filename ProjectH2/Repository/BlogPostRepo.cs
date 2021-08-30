using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ProjectH2.Controller;
using ProjectH2.Model;

namespace ProjectH2.Repository
{
    class BlogPostRepo
    {
        public EntryRepo entry = new EntryRepo();

        /// <summary>
        /// Method for add to xml with image & file
        /// </summary>
        public void SaveBlogPost(BlogPost blog, ImageCloud image, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();
            
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Blog Post
            XmlNode nodeBlog = xdoc1.CreateElement("BlogPost");
            xdoc1.DocumentElement.AppendChild(nodeBlog);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeBlog.Attributes.Append(attributeID);

            

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

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeBlog.AppendChild(nodeContact);

            XmlNode nodeContactName = xdoc1.CreateElement("Name");
            nodeContactName.InnerText = contact.FullName;
            nodeContact.AppendChild(nodeContactName);

            XmlNode nodeContactAddress = xdoc1.CreateElement("Address");
            nodeContactAddress.InnerText = contact.Address;
            nodeContact.AppendChild(nodeContactAddress);

            XmlNode nodeContactPhone = xdoc1.CreateElement("Phone");
            nodeContactPhone.InnerText = contact.Phone;
            nodeContact.AppendChild(nodeContactPhone);

            XmlNode nodeContactEmail = xdoc1.CreateElement("Email");
            nodeContactEmail.InnerText = contact.Email;
            nodeContact.AppendChild(nodeContactEmail);

            XmlNode nodeContactLinkedin = xdoc1.CreateElement("Linkedin");
            nodeContactLinkedin.InnerText = contact.Linkedin;
            nodeContact.AppendChild(nodeContactLinkedin);



            XmlNode nodeActive = xdoc1.CreateElement("Active");
            nodeActive.InnerText = blog.Active.ToString();
            nodeBlog.AppendChild(nodeActive);

            //File
            foreach (Files Cloud in file.FileList)
            {
                XmlNode nodeFile = xdoc1.CreateElement("File");
                nodeFileCloud.AppendChild(nodeFile);

                XmlNode nodeFileName = xdoc1.CreateElement("Name");
                nodeFileName.InnerText = Cloud.Name;
                nodeFile.AppendChild(nodeFileName);

                XmlNode nodeMD5 = xdoc1.CreateElement("MD5");
                nodeMD5.InnerText = Cloud.MD5Sum;
                nodeFile.AppendChild(nodeMD5);
            }


            //Image
            foreach (Image Cloud in image.ImageList)
            {
                XmlNode nodeImage = xdoc1.CreateElement("Image");
                nodeImageCloud.AppendChild(nodeImage);

                XmlNode nodeImageName = xdoc1.CreateElement("Name");
                nodeImageName.InnerText = Cloud.Name;
                nodeImage.AppendChild(nodeImageName);

                XmlNode nodeImageDescription = xdoc1.CreateElement("Description");
                nodeImageDescription.InnerText = Cloud.Description;
                nodeImage.AppendChild(nodeImageDescription);

                XmlNode nodeImagePath = xdoc1.CreateElement("Path");
                nodeImagePath.InnerText = Cloud.Path;
                nodeImage.AppendChild(nodeImagePath);
            }

            //Tag 
            foreach (Tag Cloud in tag.TagList)
            {
                XmlNode nodeTag = xdoc1.CreateElement("Tag");
                nodeTagCloud.AppendChild(nodeTag);

                XmlNode nodeName = xdoc1.CreateElement("Name");
                nodeName.InnerText = Cloud.Name;
                nodeTag.AppendChild(nodeName);

                XmlNode nodeDescription = xdoc1.CreateElement("Description");
                nodeDescription.InnerText = Cloud.Description;
                nodeTag.AppendChild(nodeDescription);
            }

            //Language
            foreach (Language Cloud in language.Languages)
            {
                XmlNode nodeLanguage = xdoc1.CreateElement("EntryLanguage");
                nodeLanguageCloud.AppendChild(nodeLanguage);

                XmlNode nodeLanguageName = xdoc1.CreateElement("Name");
                nodeLanguageName.InnerText = Cloud.Name;
                nodeLanguage.AppendChild(nodeLanguageName);
            }


            xdoc1.Save(line);
        }

        /// <summary>
        /// Method for add to xml with image
        /// </summary>
        /// <param name="blog"></param>
        /// <param name="image"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        /// <param name="street"></param>
        public void SaveBlogPost(BlogPost blog, ImageCloud image, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Blog Post
            XmlNode nodeBlog = xdoc1.CreateElement("BlogPost");
            xdoc1.DocumentElement.AppendChild(nodeBlog);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeBlog.Attributes.Append(attributeID);

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

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeBlog.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeBlog.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeBlog.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeBlog.AppendChild(nodeContact);

            XmlNode nodeContactName = xdoc1.CreateElement("Name");
            nodeContactName.InnerText = contact.FullName;
            nodeContact.AppendChild(nodeContactName);

            XmlNode nodeContactAddress = xdoc1.CreateElement("Address");
            nodeContactAddress.InnerText = contact.Address;
            nodeContact.AppendChild(nodeContactAddress);

            XmlNode nodeContactPhone = xdoc1.CreateElement("Phone");
            nodeContactPhone.InnerText = contact.Phone;
            nodeContact.AppendChild(nodeContactPhone);

            XmlNode nodeContactEmail = xdoc1.CreateElement("Email");
            nodeContactEmail.InnerText = contact.Email;
            nodeContact.AppendChild(nodeContactEmail);

            XmlNode nodeContactLinkedin = xdoc1.CreateElement("Linkedin");
            nodeContactLinkedin.InnerText = contact.Linkedin;
            nodeContact.AppendChild(nodeContactLinkedin);

            XmlNode nodeActive = xdoc1.CreateElement("Active");
            nodeActive.InnerText = blog.Active.ToString();
            nodeBlog.AppendChild(nodeActive);

            //Image
            foreach (Image Cloud in image.ImageList)
            {
                XmlNode nodeImage = xdoc1.CreateElement("Image");
                nodeImageCloud.AppendChild(nodeImage);

                XmlNode nodeImageName = xdoc1.CreateElement("Name");
                nodeImageName.InnerText = Cloud.Name;
                nodeImage.AppendChild(nodeImageName);

                XmlNode nodeImageDescription = xdoc1.CreateElement("Description");
                nodeImageDescription.InnerText = Cloud.Description;
                nodeImage.AppendChild(nodeImageDescription);

                XmlNode nodeImagePath = xdoc1.CreateElement("Path");
                nodeImagePath.InnerText = Cloud.Path;
                nodeImage.AppendChild(nodeImagePath);
            }

            //Tag 
            foreach (Tag Cloud in tag.TagList)
            {
                XmlNode nodeTag = xdoc1.CreateElement("Tag");
                nodeTagCloud.AppendChild(nodeTag);

                XmlNode nodeName = xdoc1.CreateElement("Name");
                nodeName.InnerText = Cloud.Name;
                nodeTag.AppendChild(nodeName);

                XmlNode nodeDescription = xdoc1.CreateElement("Description");
                nodeDescription.InnerText = Cloud.Description;
                nodeTag.AppendChild(nodeDescription);
            }

            //Language
            foreach (Language Cloud in language.Languages)
            {
                XmlNode nodeLanguage = xdoc1.CreateElement("EntryLanguage");
                nodeLanguageCloud.AppendChild(nodeLanguage);

                XmlNode nodeLanguageName = xdoc1.CreateElement("Name");
                nodeLanguageName.InnerText = Cloud.Name;
                nodeLanguage.AppendChild(nodeLanguageName);
            }


            xdoc1.Save(line);
        }

        /// <summary>
        /// Method for add to xml with file
        /// </summary>
        /// <param name="blog"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        /// <param name="street"></param>
        public void SaveBlogPost(BlogPost blog, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Blog Post
            XmlNode nodeBlog = xdoc1.CreateElement("BlogPost");
            xdoc1.DocumentElement.AppendChild(nodeBlog);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeBlog.Attributes.Append(attributeID);

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

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeBlog.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeBlog.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeBlog.AppendChild(nodeContact);

            XmlNode nodeContactName = xdoc1.CreateElement("Name");
            nodeContactName.InnerText = contact.FullName;
            nodeContact.AppendChild(nodeContactName);

            XmlNode nodeContactAddress = xdoc1.CreateElement("Address");
            nodeContactAddress.InnerText = contact.Address;
            nodeContact.AppendChild(nodeContactAddress);

            XmlNode nodeContactPhone = xdoc1.CreateElement("Phone");
            nodeContactPhone.InnerText = contact.Phone;
            nodeContact.AppendChild(nodeContactPhone);

            XmlNode nodeContactEmail = xdoc1.CreateElement("Email");
            nodeContactEmail.InnerText = contact.Email;
            nodeContact.AppendChild(nodeContactEmail);

            XmlNode nodeContactLinkedin = xdoc1.CreateElement("Linkedin");
            nodeContactLinkedin.InnerText = contact.Linkedin;
            nodeContact.AppendChild(nodeContactLinkedin);

            XmlNode nodeActive = xdoc1.CreateElement("Active");
            nodeActive.InnerText = blog.Active.ToString();
            nodeBlog.AppendChild(nodeActive);

            //File
            foreach (Files Cloud in file.FileList)
            {
                XmlNode nodeFile = xdoc1.CreateElement("File");
                nodeFileCloud.AppendChild(nodeFile);

                XmlNode nodeFileName = xdoc1.CreateElement("Name");
                nodeFileName.InnerText = Cloud.Name;
                nodeFile.AppendChild(nodeFileName);

                XmlNode nodeMD5 = xdoc1.CreateElement("MD5");
                nodeMD5.InnerText = Cloud.MD5Sum;
                nodeFile.AppendChild(nodeMD5);
            }

            //Tag 
            foreach (Tag Cloud in tag.TagList)
            {
                XmlNode nodeTag = xdoc1.CreateElement("Tag");
                nodeTagCloud.AppendChild(nodeTag);

                XmlNode nodeName = xdoc1.CreateElement("Name");
                nodeName.InnerText = Cloud.Name;
                nodeTag.AppendChild(nodeName);

                XmlNode nodeDescription = xdoc1.CreateElement("Description");
                nodeDescription.InnerText = Cloud.Description;
                nodeTag.AppendChild(nodeDescription);
            }

            //Language
            foreach (Language Cloud in language.Languages)
            {
                XmlNode nodeLanguage = xdoc1.CreateElement("EntryLanguage");
                nodeLanguageCloud.AppendChild(nodeLanguage);

                XmlNode nodeLanguageName = xdoc1.CreateElement("Name");
                nodeLanguageName.InnerText = Cloud.Name;
                nodeLanguage.AppendChild(nodeLanguageName);
            }


            xdoc1.Save(line);
        }

        /// <summary>
        /// Method for add to xml without image & file
        /// </summary>
        /// <param name="blog"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        /// <param name="street"></param>
        public void SaveBlogPost(BlogPost blog, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Blog Post
            XmlNode nodeBlog = xdoc1.CreateElement("BlogPost");
            xdoc1.DocumentElement.AppendChild(nodeBlog);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeBlog.Attributes.Append(attributeID);

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

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeBlog.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeBlog.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeBlog.AppendChild(nodeContact);

            XmlNode nodeContactName = xdoc1.CreateElement("Name");
            nodeContactName.InnerText = contact.FullName;
            nodeContact.AppendChild(nodeContactName);

            XmlNode nodeContactAddress = xdoc1.CreateElement("Address");
            nodeContactAddress.InnerText = contact.Address;
            nodeContact.AppendChild(nodeContactAddress);

            XmlNode nodeContactPhone = xdoc1.CreateElement("Phone");
            nodeContactPhone.InnerText = contact.Phone;
            nodeContact.AppendChild(nodeContactPhone);

            XmlNode nodeContactEmail = xdoc1.CreateElement("Email");
            nodeContactEmail.InnerText = contact.Email;
            nodeContact.AppendChild(nodeContactEmail);

            XmlNode nodeContactLinkedin = xdoc1.CreateElement("Linkedin");
            nodeContactLinkedin.InnerText = contact.Linkedin;
            nodeContact.AppendChild(nodeContactLinkedin);

            XmlNode nodeActive = xdoc1.CreateElement("Active");
            nodeActive.InnerText = blog.Active.ToString();
            nodeBlog.AppendChild(nodeActive);

            //Tag 
            foreach (Tag Cloud in tag.TagList)
            {
                XmlNode nodeTag = xdoc1.CreateElement("Tag");
                nodeTagCloud.AppendChild(nodeTag);

                XmlNode nodeName = xdoc1.CreateElement("Name");
                nodeName.InnerText = Cloud.Name;
                nodeTag.AppendChild(nodeName);

                XmlNode nodeDescription = xdoc1.CreateElement("Description");
                nodeDescription.InnerText = Cloud.Description;
                nodeTag.AppendChild(nodeDescription);
            }

            //Language
            foreach (Language Cloud in language.Languages)
            {
                XmlNode nodeLanguage = xdoc1.CreateElement("EntryLanguage");
                nodeLanguageCloud.AppendChild(nodeLanguage);

                XmlNode nodeLanguageName = xdoc1.CreateElement("Name");
                nodeLanguageName.InnerText = Cloud.Name;
                nodeLanguage.AppendChild(nodeLanguageName);
            }


            xdoc1.Save(line);
        }
    }
}
