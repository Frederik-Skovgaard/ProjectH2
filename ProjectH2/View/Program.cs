﻿using ProjectH2.Model;
using ProjectH2.Repository;
using System;
using System.Threading.Tasks;

namespace ProjectH2
{
    class Program
    {
        //Repository classes
        private static CloudRepo cloud = new CloudRepo();
        private static EntryRepo entryRepo = new EntryRepo();

        #region Entry fields

        private static BlogPostRepo postRepo = new BlogPostRepo();

        private static TagCloud BlogTagCloud = new TagCloud(Street.BlogPost);
        private static FileCloud BlogFileCloud = new FileCloud(Street.BlogPost);
        private static ImageCloud BlogImageCloud = new ImageCloud(Street.BlogPost);
        private static LanguageCloud BlogLanguageCloud = new LanguageCloud(Street.BlogPost);

        

        private static FrameworkRevieRepo revieRepo = new FrameworkRevieRepo();

        private static TagCloud FrameTagCloud = new TagCloud(Street.FrameworkReview);
        private static FileCloud FrameFileCloud = new FileCloud(Street.FrameworkReview);
        private static ImageCloud FrameImageCloud = new ImageCloud(Street.FrameworkReview);
        private static LanguageCloud FrameLanguageCloud = new LanguageCloud(Street.FrameworkReview);

        

        private static ReferenceRepo referenceRepo = new ReferenceRepo();

        private static TagCloud RefTagCloud = new TagCloud(Street.Reference);
        private static FileCloud RefFileCloud = new FileCloud(Street.Reference);
        private static ImageCloud RefImageCloud = new ImageCloud(Street.Reference);
        private static LanguageCloud RefLanguageCloud = new LanguageCloud(Street.Reference);

        #endregion


        static async Task Main(string[] args)
        {
            //Delete entry with ID 1
            entryRepo.EntryDelete(1);

            //Update head line
            entryRepo.EntryUpdate(1, "HeadLine", "New HeadLine");

            //Contact
            Contact contact = new Contact("Frederik", "Skovgaard", "Gadde", 13, "53 53 53 53", "Email@gmail.com", "www.linkind.com");


            #region Blog post test

            //Create & add tag to list
            Tag blogTag = new Tag("BlogName", "BlogDescription");
            BlogTagCloud.AddTag(blogTag);

            //Create & add file to list
            Files blogFiles = new Files("BlogName", "BlogC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml");
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
            postRepo.SaveBlogPost(blog, blog.Image, blog.File, blog.Language, blog.Tag, contact);
            #endregion


            #region Framework review Test

            //Create & add tag to list
            Tag frameTag = new Tag("FrameName", "FrameDescription");
            FrameTagCloud.AddTag(frameTag);

            Tag frameTags = new Tag("FrameName", "FrameDescription");
            FrameTagCloud.AddTag(frameTags);


            //Create & add file to list
            Files frameFile = new Files("FrameName", "FrameC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml");
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
            revieRepo.SaveFrameReview(frameworkReview, frameworkReview.Image, frameworkReview.File, frameworkReview.Language, frameworkReview.Tag, contact);
            #endregion


            #region Reference Test

            //Create & add tag to list
            Tag refTag = new Tag("RefName", "RefDescription");
            RefTagCloud.AddTag(refTag);

            Tag refTags = new Tag("RefName", "RefDescription");
            RefTagCloud.AddTag(refTags);
            
            Tag refTagss = new Tag("RefName", "RefDescription");
            RefTagCloud.AddTag(refTagss);

            //Create & add file to list
            Files refFile = new Files("RefName", "RefC#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml");
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
            referenceRepo.SaveReference(reference, reference.Image, reference.File, reference.Language, reference.Tag, contact);
            #endregion


            #region Read to lists

            //Read xml & add to list
            await cloud.ReadFileToLists(blogTag, blogImage, blogLanguage, blogFiles);

            //Read xml & add to list
            await cloud.ReadFileToLists(frameTag, frameImage, frameLanguage, frameFile);

            //Read xml & add to list
            await cloud.ReadFileToLists(refTag, refImage, refLanguge, refFile);
            #endregion


            #region Resualt

            //Blog Post lsits check
            Console.Write("Total amount of tags in xml fie: ");
            Console.WriteLine(blogTag.TagsList.Count);

            Console.WriteLine("------------------------------");

            Console.Write("Blog Post Tag Cloud count: ");
            Console.WriteLine(BlogTagCloud.TagList.Count);

            //Framework review lsits check
            Console.WriteLine("------------------------------");
            Console.Write("Framework Review Tag Cloud count: ");
            Console.WriteLine(FrameTagCloud.TagList.Count);

            //Reference lsits check
            Console.WriteLine("------------------------------");
            Console.Write("Reference Tag Cloud count: ");
            Console.WriteLine(RefTagCloud.TagList.Count);
            Console.ReadLine();
            #endregion
        }
    }
}
