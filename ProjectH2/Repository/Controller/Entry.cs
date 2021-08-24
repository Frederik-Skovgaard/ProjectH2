using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Model;

namespace ProjectH2.Repository.Controller
{
    public enum Street { BlogPost, FrameworkReview, Reference}

    //TODO: Add properties to Entry
    //TODO: Add blog post Class/constructer
    //TODO: Add framework review Class/constructer
    //TODO: Add reference Class/constructer

    public class Entry
    {
        //Entry propertys
        #region Entry prop
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public string HeadLine { get; set; }


        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Image Image { get; set; }
        public Files File { get; set; }
        public Tag Tag { get; set; }
        public Language Language { get; set; }


        public string Link { get; set; }
        public int NummberOfStart { get; set; }


        #endregion
    }


    //Create Blog post
    class BlogPost : Entry
    {
        

        public BlogPost(string text, string headLine, DateTime startDate, DateTime endDate, Image image, Files file, Tag tag, Language language, bool active)
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

        public FrameworkReview(string text, Image image, int nummberOfStar, string link, string headLine, Files file, Tag tag, Language language, bool active)
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

        public Reference(string text, Image image, Files file, Tag tag, Language language, bool active)
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
