using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Model;

namespace ProjectH2.Repository.Controller
{
    //TODO: add properties to entry
    public class Entry
    {
        //Entry propertys
        #region Entry prop
        public string FullName => Contact.FullName;
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public string HeadLine { get; set; }


        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Image Image { get; set; }
        public File File { get; set; }
        public Tag Tag { get; set; }
        public Language Language { get; set; }


        public string Link { get; set; }
        public int NummberOfStart { get; set; }


        private Contact Contact;

        #endregion


    }

    //TODO: Make Contructor for blog post

    //Create Blog post
    class BlogPost : Entry
    {
        

        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, Image image, File file, Tag tag, Language language)
        {
            Text = text;
            HeadLine = headLine;
            StartDate = startDate;
            EndDate = endDate;
            Image = image;
            File = file;
            Tag = tag;
            Language = language;
        }
    }

    //TODO: Make Contructor for frame work review

    //Create Frame work review
    class FrameworkReview : Entry
    {

        public FrameworkReview(string text, Image image, int nummberOfStar, string link, string headLine, File file, Tag tag, Language language)
        {
            Text = text;
            Image = image;
            NummberOfStart = nummberOfStar;
            Link = link;
            HeadLine = headLine;
            File = file;
            Tag = tag;
            Language = language;
        }
    }

    //TODO: Make Contructor for reference

    //Create a reference
    class Reference : Entry
    {
        public Reference(string text, Image image, File file, Tag tag, Language language)
        {
            Text = text;
            Image = image;
            File = file;
            Tag = tag;
            Language = language;
        }
    }
}
