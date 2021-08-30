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
    class ReferenceRepo
    {
        public EntryRepo entry = new EntryRepo();

        /// <summary>
        /// Method for saving reference in xml file with image & file
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveReference(Reference reference, ImageCloud image, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Reference
            XmlNode nodeReference = xdoc1.CreateElement("Reference");
            xdoc1.DocumentElement.AppendChild(nodeReference);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeReference.Attributes.Append(attributeID);

            XmlNode nodeText = xdoc1.CreateElement("Name");
            nodeText.InnerText = reference.Text;
            nodeReference.AppendChild(nodeText);

            XmlNode nodeFileCloud = xdoc1.CreateElement("FileCloud");
            nodeReference.AppendChild(nodeFileCloud);

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeReference.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeReference.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeReference.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeReference.AppendChild(nodeContact);

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
            nodeActive.InnerText = reference.Active.ToString();
            nodeReference.AppendChild(nodeActive);

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
        /// Method for saving reference in xml file with file
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveReference(Reference reference, FileCloud file, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Reference
            XmlNode nodeReference = xdoc1.CreateElement("Reference");
            xdoc1.DocumentElement.AppendChild(nodeReference);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeReference.Attributes.Append(attributeID);

            XmlNode nodeText = xdoc1.CreateElement("Name");
            nodeText.InnerText = reference.Text;
            nodeReference.AppendChild(nodeText);

            XmlNode nodeFileCloud = xdoc1.CreateElement("FileCloud");
            nodeReference.AppendChild(nodeFileCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeReference.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeReference.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeReference.AppendChild(nodeContact);

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
            nodeActive.InnerText = reference.Active.ToString();
            nodeReference.AppendChild(nodeActive);

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
        /// Method for saving reference in xml file with image
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveReference(Reference reference, ImageCloud image, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Reference
            XmlNode nodeReference = xdoc1.CreateElement("Reference");
            xdoc1.DocumentElement.AppendChild(nodeReference);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeReference.Attributes.Append(attributeID);

            XmlNode nodeText = xdoc1.CreateElement("Name");
            nodeText.InnerText = reference.Text;
            nodeReference.AppendChild(nodeText);

            XmlNode nodeImageCloud = xdoc1.CreateElement("ImageCloud");
            nodeReference.AppendChild(nodeImageCloud);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeReference.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeReference.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeReference.AppendChild(nodeContact);

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
            nodeActive.InnerText = reference.Active.ToString();
            nodeReference.AppendChild(nodeActive);


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
        /// Method for saving reference in xml file without image & file
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="language"></param>
        /// <param name="tag"></param>
        public void SaveReference(Reference reference, LanguageCloud language, TagCloud tag, Contact contact)
        {
            entry.IDCatcher();

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XmlDocument xdoc1 = new XmlDocument();
            xdoc1.Load(line);

            //Reference
            XmlNode nodeReference = xdoc1.CreateElement("Reference");
            xdoc1.DocumentElement.AppendChild(nodeReference);

            XmlAttribute attributeID = xdoc1.CreateAttribute("ID");
            attributeID.Value = entry.ID.ToString();
            nodeReference.Attributes.Append(attributeID);

            XmlNode nodeText = xdoc1.CreateElement("Name");
            nodeText.InnerText = reference.Text;
            nodeReference.AppendChild(nodeText);

            XmlNode nodeTagCloud = xdoc1.CreateElement("TagCloud");
            nodeReference.AppendChild(nodeTagCloud);

            XmlNode nodeLanguageCloud = xdoc1.CreateElement("LanguageCloud");
            nodeReference.AppendChild(nodeLanguageCloud);

            //Contact 
            XmlNode nodeContact = xdoc1.CreateElement("Contact");
            nodeReference.AppendChild(nodeContact);

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
            nodeActive.InnerText = reference.Active.ToString();
            nodeReference.AppendChild(nodeActive);

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
