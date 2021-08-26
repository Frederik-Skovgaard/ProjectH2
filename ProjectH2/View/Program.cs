using System;
using System.Security.Cryptography;
using ProjectH2.Model;
using ProjectH2.Controller;
using ProjectH2.Repository;

namespace ProjectH2
{
    class Program
    {
        static EntryRepo entry = new EntryRepo();

        static void Main(string[] args)
        {
            

            TagCloud tagCloud = new TagCloud();
            Tag tag = new Tag("name", "description");

            //FileCloud fileCloud = new FileCloud();
            //Files files = new Files("name", "C#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");

            //ImageCloud imageCloud = new ImageCloud();
            //Image image = new Image("name", "description", @"C:\");

            //LanguageCloud languageCloud = new LanguageCloud();
            //Language language = new Language("name");

            //BlogPost blog = new BlogPost("Text", "HeadLine", DateTime.Now, DateTime.Today, fileCloud, imageCloud, tagCloud, languageCloud, true);

            //entry.SaveText(blog, image, files, language, tag, Street.BlogPost);

            TagCloud.Reader();
            
        }
    }
}
