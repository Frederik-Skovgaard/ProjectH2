using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
   
    public class FileCloud
    {
        //File
        public Street Street { get; set; }
        public List<Files> File => file.FileList;

        private Files file;


        /// <summary>
        /// Method for finding files
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Files FindFile(string name) { Files file = File.Find(x => x.Name == name); return file; }
    }

    //File class
    public class Files : FileCloud
    {
        //File proparty
        public string Name => name;
        public string Language => language;
        public string MD5 => md5sum;
        public string Path => path;

        private string name;
        private string language;
        private string md5sum;
        private string path;

        public List<Files> FileList => fileList;
        private List<Files> fileList;

        /// <summary>
        /// Constructor for adding languages to entry
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="language_"></param>
        /// <param name="path_"></param>
        /// <param name="street"></param>
        public Files(string name_, string language_, string path_, Street street)
        {
            name = name_;
            language = language_;
            path = path_;

            Street = street;

            fileList.Add(new Files(name_, language_, path_, street));
        }

        
    }
}
