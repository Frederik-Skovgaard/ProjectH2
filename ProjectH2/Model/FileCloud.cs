using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProjectH2.Controller;

namespace ProjectH2.Model
{
   
    public class FileCloud
    {
        //File
        public Street Street { get; set; }
        public List<Files> FileList => file.FilesList;

        private readonly Files file;



        /// <summary>
        /// Method for finding files
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Files FindFile(string name) { Files file = FileList.Find(x => x.Name == name); return file; }
    }

    //File class
    public class Files
    {
        //File proparty
        public string Name => name;
        public string Language => language;
        public string Path => path;
        public string MD5Sum => md5;
        public List<Files> FilesList => filesList;

        private string name;
        private string language;
        private string path;
        private string md5;

        private List<Files> filesList = new List<Files>();


        /// <summary>
        /// Constructor for adding languages to entry
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="language_"></param>
        /// <param name="path_"></param>
        /// <param name="street"></param>
        public Files(string name_, string language_, string path_)
        {
            name = name_;
            language = language_;
            path = path_;

            md5 = CheckMD5(path_);

            filesList.Add(new Files(name_, language_, path_));
        }

        /// <summary>
        /// Read xml file and add to list
        /// </summary>
        public void Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);
            IEnumerable<XElement> filXML = xdoc.Root.Descendants("File");

            foreach (var filXml in filXML)
            {
                string fileName = filXml.Element("Name").Value;
                string fileLanguage = filXml.Element("Language").Value;
                string filePath = filXml.Element("Path").Value;

                filesList.Add(new Files(fileName, fileLanguage, filePath));

            }
        }

        /// <summary>
        /// Method for encrypting file and returning the converted hash as a string
        /// </summary>
        /// <param name="path_"></param>
        /// <returns></returns>
        public string CheckMD5(string path_)
        {
            using (MD5 md5Sm_ = MD5.Create())
            {
                //Open & Read file
                using (FileStream stream = File.OpenRead(path_))
                {
                    byte[] hash = md5Sm_.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
