using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Model;
using ProjectH2.Interfaces;

namespace ProjectH2.Repository.Controller
{
    public enum Street { BlogPost, FrameworkReview, Reference}


    abstract class Entry : IEntry
    {
        //Entry propertys
        #region Entry prop
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public string HeadLine { get; set; }


        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ImageCloud Image { get; set; }
        public FileCloud File { get; set; }
        public TagCloud Tag { get; set; }
        public LanguageCloud Language { get; set; }


        public string Link { get; set; }
        public int NummberOfStart { get; set; }

        #endregion
    }


    //Create Blog post
    class BlogPost : Entry
    {
        
        /// <summary>
        /// Contrutor for adding a blog post
        /// </summary>
        /// <param name="text"></param>
        /// <param name="headLine"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="tag"></param>
        /// <param name="language"></param>
        /// <param name="active"></param>
        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, ImageCloud image, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            Image = image;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }
    }

    //Create Frame work review
    class FrameworkReview : Entry
    {
        /// <summary>
        /// Contrutor for adding a framework review
        /// </summary>
        /// <param name="text"></param>
        /// <param name="image"></param>
        /// <param name="nummberOfStar"></param>
        /// <param name="link"></param>
        /// <param name="headLine"></param>
        /// <param name="file"></param>
        /// <param name="tag"></param>
        /// <param name="language"></param>
        /// <param name="active"></param>
        public FrameworkReview(string text, ImageCloud image, int nummberOfStar, string link, string headLine, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Image = image;
            NummberOfStart = nummberOfStar;
            Link = link;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }
    }

    //Create a reference
    class Reference : Entry
    {
        /// <summary>
        /// Construtor for making a reference
        /// </summary>
        /// <param name="text"></param>
        /// <param name="image"></param>
        /// <param name="file"></param>
        /// <param name="tag"></param>
        /// <param name="language"></param>
        /// <param name="active"></param>
        public Reference(string text, ImageCloud image, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Image = image;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }

        
    }
}
