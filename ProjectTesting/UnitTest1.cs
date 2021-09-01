using System;
using Xunit;
using ProjectH2.Model;
using ProjectH2.Controller;
using ProjectH2.Repository;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTesting
{
    public class UnitTest1
    {
        public CloudRepo cloud = new CloudRepo();
        public EntryRepo entryRepo = new EntryRepo();

        /// <summary>
        /// Count how many tags in tag cloud
        /// </summary>
        [Fact]
        public void TagCloudCounter()
        {
            //Arrange
            TagCloud tagCloud = new TagCloud();

            for (int i = 0; i < 100; i++)
            {
                Tag tag = new Tag($"Name{i}", "Description{i}");
                tagCloud.AddTag(tag);
            }

            //Act
            int result = tagCloud.TagList.Count;

            //Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void ReadXML()
        {
            //Arrange
            TagCloud BlogTagCloud = new TagCloud();
            FileCloud BlogFileCloud = new FileCloud();
            ImageCloud BlogImageCloud = new ImageCloud();
            LanguageCloud BlogLanguageCloud = new LanguageCloud();
            BlogPostRepo postRepo = new BlogPostRepo();

            //Contact
            Contact contact = new Contact("Frederik", "Skovgaard", "Gadde", 13, "53 53 53 53", "Email@gmail.com", "www.linkind.com");

            //Blog post test
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


            //Act
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);

            XElement entry = xdoc.Root.Elements("BlogPost")
                .FirstOrDefault(w => (int)w.Attribute("ID") == 1);


            //Assert
            Assert.Equal(blog.Text, entry.Element("Text").Value);

        }

        /// <summary>
        /// Test if headline is changed
        /// </summary>
        [Fact]
        public void UpdateXML()
        {
            //Arrange
            entryRepo.EntryUpdate(1, "HeadLine", "New HeadLine");

            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);

            XElement entry = xdoc.Root.Elements("BlogPost")
                .FirstOrDefault(w => (int)w.Attribute("ID") == 1);


            //Act
            string result = entry.Element("HeadLine").Value;


            //Assert
            Assert.Equal("New HeadLine", result);

        }
    }
}
