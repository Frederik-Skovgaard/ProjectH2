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
            Files file = new Files("Name", "C#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.txt");
            Tag tag = new Tag("OwO", "Desciption");
            Language language = new Language("C#");
            Image image = new Image("name", "Description", @"C:\");
            

            LanguageCloud languageCloud = new LanguageCloud();
            TagCloud tagCloud = new TagCloud();
            ImageCloud imageCloud = new ImageCloud();
            FileCloud fileCloud = new FileCloud();

            BlogPost blogPost = new BlogPost("", "", DateTime.Now, DateTime.Today, fileCloud, imageCloud, tagCloud, languageCloud, true);
            BlogPost blogPost1 = new BlogPost("", "", DateTime.Now, DateTime.Today, imageCloud, tagCloud, languageCloud, true);
            BlogPost blogPost2 = new BlogPost("", "", DateTime.Now, DateTime.Today, fileCloud, tagCloud, languageCloud, true);
            BlogPost blogPost3 = new BlogPost("", "", DateTime.Now, DateTime.Today, tagCloud, languageCloud, true);
        }
    }
}
