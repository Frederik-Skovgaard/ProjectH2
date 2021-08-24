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
        public List<File> File => file.FileList;

        private File file;        


    }

    //File class
    public class File : FileCloud
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

        public List<File> FileList => fileList;
        private List<File> fileList;

        /// <summary>
        /// Constructor for adding languages to entry
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="language_"></param>
        /// <param name="path_"></param>
        /// <param name="street"></param>
        public File(string name_, string language_, string path_, Street street)
        {
            name = name_;
            language = language_;
            path = path_;

            Street = street;

            fileList.Add(new File(name, language, path, Street));
        }

        /// <summary>
        /// Method for finding files
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public File FindFile(string name) { File file = FileList.Find(x => x.Name == name); return file; }
    }
}
