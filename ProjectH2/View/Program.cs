using System;
using System.Security.Cryptography;
using ProjectH2.Model;
using ProjectH2.Controller;
using ProjectH2.Repository;

namespace ProjectH2
{
    class Program
    {
        private static CloudRepo cloud = new CloudRepo();
        private static BlogPostRepo postRepo = new BlogPostRepo();

        //For Blog post
        private static TagCloud BlogTagCloud = new TagCloud();
        private static FileCloud BlogFileCloud = new FileCloud();
        private static ImageCloud BlogImageCloud = new ImageCloud();
        private static LanguageCloud BlogLanguageCloud = new LanguageCloud();

        //For Framework review
        private static TagCloud FrameTagCloud = new TagCloud();
        private static FileCloud FrameFileCloud = new FileCloud();
        private static ImageCloud FrameImageCloud = new ImageCloud();
        private static LanguageCloud FrameLanguageCloud = new LanguageCloud();

        //For Reference
        private static TagCloud RefTagCloud = new TagCloud();
        private static FileCloud RefFileCloud = new FileCloud();
        private static ImageCloud RefImageCloud = new ImageCloud();
        private static LanguageCloud RefLanguageCloud = new LanguageCloud();



        static void Main(string[] args)
        {
            //Blog post test
            //Create & add tag to list
            Tag tag = new Tag("owo", "owowowowoow");
            BlogTagCloud.AddTag(tag);
            tag.AddTag(tag);

            //Create & add file to list
            Files files = new Files("nameFile", "Java", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");
            BlogFileCloud.AddFile(files);

            //Create & add image to list
            Image image = new Image("imagename", "Descc", @"F:\");
            BlogImageCloud.AddImage(image);

            //Create & add language to list
            Language language = new Language("XDC#");
            BlogLanguageCloud.AddLanguage(language);

            //Read xml & add to list
            cloud.ReadFileToLists(tag, image, language, files);

            //Create Blog post & add to xml file
            BlogPost blog = new BlogPost("Unes Anus", "BigTitle", DateTime.Now, DateTime.Today, BlogFileCloud, BlogImageCloud, BlogTagCloud, BlogLanguageCloud, true);
            postRepo.SaveBlogPost(blog, blog.Image, blog.File, blog.Language, blog.Tag);



            //Framework review Test



            //Reference Test


            //Resualt
            Console.WriteLine(tag.TagsList.Count);
            Console.WriteLine(BlogTagCloud.TagList.Count);
            Console.ReadLine();
        }
    }
}
