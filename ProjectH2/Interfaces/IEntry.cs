using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Model;

namespace ProjectH2.Interfaces
{
    
    interface IEntry
    {
        //Properties used in entry
        string Name { get; set; }
        DateTime Date { get; set; }
        bool Active { get; set; }
        string HeadLine { get; set; }


        string Text { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        ImageCloud Image { get; set; }
        FileCloud File { get; set; }
        TagCloud Tag { get; set; }
        LanguageCloud Language { get; set; }


        string Link { get; set; }
        int NummberOfStart { get; set; }
    }
}
