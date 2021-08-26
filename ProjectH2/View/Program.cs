﻿using System;
using System.Security.Cryptography;
using ProjectH2.Model;
using ProjectH2.Controller;
using ProjectH2.Repository;

namespace ProjectH2
{
    class Program
    {
        static BlogPostRepo postRepo;

        static void Main(string[] args)
        {

            Tag tag = new Tag("name", "description");
            TagCloud tagCloud = new TagCloud();

            Files files = new Files("name", "C#", @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.txt");
            FileCloud fileCloud = new FileCloud();

            Image image = new Image("name", "description", @"C:\");
            ImageCloud imageCloud = new ImageCloud();

            Language language = new Language("name");
            LanguageCloud languageCloud = new LanguageCloud();
            

            BlogPost blog = new BlogPost("Text", "HeadLine", DateTime.Now, DateTime.Today, fileCloud, imageCloud, tagCloud, languageCloud, true);


            postRepo.SaveBlogPost(blog, imageCloud, fileCloud, languageCloud, tagCloud);


        }
    }
}