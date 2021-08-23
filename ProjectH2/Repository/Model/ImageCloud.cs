using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    class ImageCloud
    {
       
    }

    class Image : ImageCloud
    {
        public string Name => name;
        public string Description => decscription;
        public string Path => path;

        private string name;
        private string decscription;
        private string path;

        public Image(string name_, string description_, string path_)
        {
            name = name_;
            decscription = description_;
            path = path_;
        }
    }
}
