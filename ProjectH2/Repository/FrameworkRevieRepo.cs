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
    class FrameworkRevieRepo
    {
        /// <summary>
        /// Method for saving framework review in xml file with file & image
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveFrameReview(FrameworkReview framework, ImageCloud image, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //FrameWork Reveiw
            XmlNode nodeFramework = xdoc1.CreateElement("FrameWorkReview");
            xdoc1.DocumentElement.AppendChild(nodeFramework);

            XmlNode nodeText = xdoc1.CreateElement("Text");
            nodeText.InnerText = framework.Text;
            nodeFramework.AppendChild(nodeText);

            XmlNode nodeNummberOfStars = xdoc1.CreateElement("NummberOfStars");
            nodeNummberOfStars.InnerText = framework.NummberOfStart.ToString();
            nodeFramework.AppendChild(nodeNummberOfStars);

            XmlNode nodeLink = xdoc1.CreateElement("Link");
            nodeLink.InnerText = framework.Link;
            nodeFramework.AppendChild(nodeLink);

            XmlNode nodeFileCloud = xdoc1.CreateElement("FileCloud");
            nodeFramework.AppendChild(nodeFileCloud);

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeFramework.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeFramework.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeFramework.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeFramework.AppendChild(nodeContact);

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
            nodeActive.InnerText = framework.Active.ToString();
            nodeFramework.AppendChild(nodeActive);

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
        /// Method for saving framework review in xml file with file
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveFrameReview(FrameworkReview framework, ImageCloud image, LanguageCloud language, TagCloud tag, Contact contact)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //FrameWork Reveiw
            XmlNode nodeFramework = xdoc1.CreateElement("FrameWorkReview");
            xdoc1.DocumentElement.AppendChild(nodeFramework);

            XmlNode nodeText = xdoc1.CreateElement("Text");
            nodeText.InnerText = framework.Text;
            nodeFramework.AppendChild(nodeText);

            XmlNode nodeNummberOfStars = xdoc1.CreateElement("NummberOfStars");
            nodeNummberOfStars.InnerText = framework.NummberOfStart.ToString();
            nodeFramework.AppendChild(nodeNummberOfStars);

            XmlNode nodeLink = xdoc1.CreateElement("Link");
            nodeLink.InnerText = framework.Link;
            nodeFramework.AppendChild(nodeLink);

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeFramework.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeFramework.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeFramework.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeFramework.AppendChild(nodeContact);

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
            nodeActive.InnerText = framework.Active.ToString();
            nodeFramework.AppendChild(nodeActive);


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
        /// Method for saving framework review in xml file with file
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveFrameReview(FrameworkReview framework, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //FrameWork Reveiw
            XmlNode nodeFramework = xdoc1.CreateElement("FrameWorkReview");
            xdoc1.DocumentElement.AppendChild(nodeFramework);

            XmlNode nodeText = xdoc1.CreateElement("Text");
            nodeText.InnerText = framework.Text;
            nodeFramework.AppendChild(nodeText);

            XmlNode nodeNummberOfStars = xdoc1.CreateElement("NummberOfStars");
            nodeNummberOfStars.InnerText = framework.NummberOfStart.ToString();
            nodeFramework.AppendChild(nodeNummberOfStars);

            XmlNode nodeLink = xdoc1.CreateElement("Link");
            nodeLink.InnerText = framework.Link;
            nodeFramework.AppendChild(nodeLink);

            XmlNode nodeFileCloud = xdoc1.CreateElement("FileCloud");
            nodeFramework.AppendChild(nodeFileCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeFramework.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeFramework.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeFramework.AppendChild(nodeContact);

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
            nodeActive.InnerText = framework.Active.ToString();
            nodeFramework.AppendChild(nodeActive);

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
        /// Method for saving framework review in xml file without file & image
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveFrameReview(FrameworkReview framework, LanguageCloud language, TagCloud tag, Contact contact)
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //FrameWork Reveiw
            XmlNode nodeFramework = xdoc1.CreateElement("FrameWorkReview");
            xdoc1.DocumentElement.AppendChild(nodeFramework);

            XmlNode nodeText = xdoc1.CreateElement("Text");
            nodeText.InnerText = framework.Text;
            nodeFramework.AppendChild(nodeText);

            XmlNode nodeNummberOfStars = xdoc1.CreateElement("NummberOfStars");
            nodeNummberOfStars.InnerText = framework.NummberOfStart.ToString();
            nodeFramework.AppendChild(nodeNummberOfStars);

            XmlNode nodeLink = xdoc1.CreateElement("Link");
            nodeLink.InnerText = framework.Link;
            nodeFramework.AppendChild(nodeLink);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeFramework.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeFramework.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeFramework.AppendChild(nodeContact);

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
            nodeActive.InnerText = framework.Active.ToString();
            nodeFramework.AppendChild(nodeActive);

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
