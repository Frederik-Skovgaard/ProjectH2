using System;
using System.Security.Cryptography;
using ProjectH2.Repository.Model;
using ProjectH2.Repository.Controller;

namespace ProjectH2
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            

            Tag tag = new Tag("OwO", "Desciption");
            tag.SaveText(tag);

            TagCloud tagCloud = new TagCloud();



            tagCloud.Reader();
        }
    }
}
