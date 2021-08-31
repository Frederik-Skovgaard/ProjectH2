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
        public  CloudRepo cloud = new CloudRepo();
        public  EntryRepo entryRepo = new EntryRepo();

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
        public void ReaderXML()
        {
            //Arrange
            entryRepo.EntryUpdate(1);

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
