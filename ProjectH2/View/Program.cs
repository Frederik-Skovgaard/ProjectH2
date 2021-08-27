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

        //For Blog post
        private static BlogPostRepo postRepo = new BlogPostRepo();

        private static TagCloud BlogTagCloud = new TagCloud();
        private static FileCloud BlogFileCloud = new FileCloud();
        private static ImageCloud BlogImageCloud = new ImageCloud();
        private static LanguageCloud BlogLanguageCloud = new LanguageCloud();

        //For Framework review
        private static FrameworkRevieRepo revieRepo = new FrameworkRevieRepo();

        private static TagCloud FrameTagCloud = new TagCloud();
        private static FileCloud FrameFileCloud = new FileCloud();
        private static ImageCloud FrameImageCloud = new ImageCloud();
        private static LanguageCloud FrameLanguageCloud = new LanguageCloud();

        //For Reference
        private static ReferenceRepo referenceRepo = new ReferenceRepo();

        private static TagCloud RefTagCloud = new TagCloud();
        private static FileCloud RefFileCloud = new FileCloud();
        private static ImageCloud RefImageCloud = new ImageCloud();
        private static LanguageCloud RefLanguageCloud = new LanguageCloud();



        static void Main(string[] args)
        {
            //Blog post test
            //Create & add tag to list
            Tag blogTag = new Tag("BlogName", "BlogDescription");
            BlogTagCloud.AddTag(blogTag);
            blogTag.AddTag(blogTag);

            //Create & add file to list
            Files blogFiles = new Files("BlogName", "BlogC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");
            BlogFileCloud.AddFile(new Files(blogFiles.Name, blogFiles.MD5Sum));
            blogFiles.AddFile(new Files(blogFiles.Name, blogFiles.MD5Sum));

            //Create & add image to list
            Image blogImage = new Image("BlogName", "BlogDescription", @"F:\");
            BlogImageCloud.AddImage(blogImage);
            blogImage.AddImage(blogImage);

            //Create & add language to list
            Language blogLanguage = new Language("BlogC#");
            BlogLanguageCloud.AddLanguage(blogLanguage);
            blogLanguage.AddLanguage(blogLanguage);

            //Create Blog post & add to xml file
            BlogPost blog = new BlogPost("Unes Anus", "BigTitle", DateTime.Now, DateTime.Today, BlogFileCloud, BlogImageCloud, BlogTagCloud, BlogLanguageCloud, true);
            postRepo.SaveBlogPost(blog, blog.Image, blog.File, blog.Language, blog.Tag);



            //Framework review Test

            //Create & add tag to list
            Tag frameTag = new Tag("FrameName", "FrameDescription");
            FrameTagCloud.AddTag(frameTag);
            frameTag.AddTag(frameTag);

            //Create & add file to list
            Files frameFile = new Files("FrameName", "FrameC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");
            FrameFileCloud.AddFile(new Files(frameFile.Name, frameFile.MD5Sum));
            frameFile.AddFile(new Files(frameFile.Name, frameFile.MD5Sum));

            //Create & add image to list
            Image frameImage = new Image("FrameName", "FrameDescription", "FramePath");
            FrameImageCloud.AddImage(frameImage);
            frameImage.AddImage(frameImage);

            //Create & add language to list
            Language frameLanguage = new Language("FrameC#");
            FrameLanguageCloud.AddLanguage(frameLanguage);
            frameLanguage.AddLanguage(frameLanguage);

            //Create a framework review & add to xml file
            FrameworkReview frameworkReview = new FrameworkReview("Text", 5, "www.link.dk", "HeadLine", FrameFileCloud, FrameImageCloud, FrameTagCloud, FrameLanguageCloud, true);
            revieRepo.SaveFrameReview(frameworkReview, frameworkReview.Image, frameworkReview.File, frameworkReview.Language, frameworkReview.Tag);


            //Reference Test

            //Create & add tag to list
            Tag refTag = new Tag("RefName", "RefDescription");
            RefTagCloud.AddTag(refTag);
            refTag.AddTag(refTag);

            //Create & add file to list
            Files refFile = new Files("RefName", "RefC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");
            RefFileCloud.AddFile(new Files(refFile.Name, refFile.MD5Sum));
            refFile.AddFile(new Files(refFile.Name, refFile.MD5Sum));

            //Create & add image to list
            Image refImage = new Image("RefName", "RefDescription", "RefPath");
            RefImageCloud.AddImage(refImage);
            refImage.AddImage(refImage);

            //Create & add language to list
            Language refLanguge = new Language("RefC#");
            RefLanguageCloud.AddLanguage(refLanguge);
            refLanguge.AddLanguage(refLanguge);

            //Create a reference & add to xml file
            Reference reference = new Reference("RefText", RefImageCloud, RefFileCloud, RefTagCloud, RefLanguageCloud, true);
            referenceRepo.SaveReference(reference, reference.Image, reference.File, reference.Language, reference.Tag);



            //Read to lists

            //Read xml & add to list
            cloud.ReadFileToLists(blogTag, blogImage, blogLanguage, blogFiles);

            //Read xml & add to list
            cloud.ReadFileToLists(frameTag, frameImage, frameLanguage, frameFile);

            //Read xml & add to list
            cloud.ReadFileToLists(refTag, refImage, refLanguge, refFile);

            //Resualt

            //Blog Post lsits check
            Console.WriteLine(blogTag.TagsList.Count);
            Console.WriteLine(BlogTagCloud.TagList.Count);

            //Framework review lsits check
            Console.WriteLine(frameTag.TagsList.Count);
            Console.WriteLine(FrameTagCloud.TagList.Count);

            //Reference lsits check
            Console.WriteLine(refTag.TagsList.Count);
            Console.WriteLine(RefTagCloud.TagList.Count);
            Console.ReadLine();
        }
    }
}
