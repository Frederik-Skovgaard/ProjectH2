using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectH2.Repository.Model
{
    public class FileCloud
    {
        //File & Path
        public string Path => file.Path;
        public File CloudFile => file;
        public List<File> FileList => file.FileList;

        private File file;

       




    }

    //File class
    public class File
    {
        //File proparty
        public string Nmae => name;
        public string Language => language;
        public string MD5 => md5sum;
        public string Path => path;

        private string name;
        private string language;
        private string md5sum;
        private string path;

        //File List
        public List<File> FileList => fileList;
        private List<File> fileList;

        public File()
        {

        }


    }
}
