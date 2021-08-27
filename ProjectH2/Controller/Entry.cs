using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProjectH2.Interfaces;
using ProjectH2.Model;

namespace ProjectH2.Controller
{
    public enum Street { BlogPost, FrameworkReview, Reference}

    //TODO: Add id
    //TODO: Add read method

    public abstract class Entry : IEntry
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
        
    
        //Constructor without image & file
        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            Tag = tag;
            Language = language;
            Active = active;

        }

        //Constructor with image
        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, ImageCloud image, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            Image = image;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Contructor with file
        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with file & image
        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, FileCloud file, ImageCloud image, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            File = file;
            Image = image;
            Tag = tag;
            Language = language;
            Active = active;
        }
    }

    //Create Frame work review
    class FrameworkReview : Entry
    {
        //Constructor without file & image
        public FrameworkReview(string text, int nummberOfStar, string link, string headLine, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            NummberOfStart = nummberOfStar;
            Link = link;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with image
        public FrameworkReview(string text, ImageCloud image, int nummberOfStar, string link, string headLine, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Image = image;
            NummberOfStart = nummberOfStar;
            Link = link;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with file
        public FrameworkReview(string text, int nummberOfStar, string link, string headLine, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            NummberOfStart = nummberOfStar;
            Link = link;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with file & image
        public FrameworkReview(string text, int nummberOfStar, string link, string headLine, FileCloud file, ImageCloud imag, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            NummberOfStart = nummberOfStar;
            Link = link;
            File = file;
            Image = imag;
            Tag = tag;
            Language = language;
            Active = active;
        }
    }

    //Create a reference
    class Reference : Entry
    {
        //Constructor with file & image
        public Reference(string text, ImageCloud image, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Image = image;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with image
        public Reference(string text, ImageCloud image, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Image = image;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor with file
        public Reference(string text, FileCloud file, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            File = file;
            Tag = tag;
            Language = language;
            Active = active;
        }

        //Constructor without image & file
        public Reference(string text, TagCloud tag, LanguageCloud language, bool active)
        {
            Text = text;
            Tag = tag;
            Language = language;
            Active = active;
        }

        



    }
}
