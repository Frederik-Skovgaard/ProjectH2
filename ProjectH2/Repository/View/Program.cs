using System;
using System.IO;
using ProjectH2.Repository.Controller;
using ProjectH2.Repository.Model;

namespace ProjectH2
{
    class Program
    {
        static TagCloud tagCloud = new TagCloud();
        static LanguageCloud languageCloud = new LanguageCloud();
        static FileCloud fileCloud = new FileCloud();
        static ImageCloud imageCloud = new ImageCloud();


        static void Main(string[] args)
        {
            Image image = new Image("Image", "nice image", @"C:\sss", Street.BlogPost);
            Files file = new Files("name", "C#", @"C:\sss", Street.BlogPost);
            Language language = new Language("Name", "reference");
            Tag tag = new Tag("name", "Description");      
            

            Contact contact = new Contact("Frederik", "Skovgaard", "Address", 14, "55 55 55 55", "Email@gmail.com", "www.link.com");


            BlogPost blogPost = new BlogPost("text", "Headline", DateTime.Now, DateTime.Today, imageCloud, fileCloud, tagCloud, languageCloud, true);
            FrameworkReview frameworkReview = new FrameworkReview("text", imageCloud, 5, "www.link.dk", "Headline", fileCloud, tagCloud, languageCloud, false);
            Reference reference = new Reference("text", imageCloud, fileCloud, tagCloud, languageCloud, true);
        }

        
    }
}
