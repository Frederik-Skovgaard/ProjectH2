using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Controller;

namespace ProjectH2.Model
{
    public class LanguageCloud
    {
        //Properties
        public Street Street { get; set; }
        public List<Language> Languages => languages;

        private List<Language> languages = new List<Language>();

        /// <summary>
        /// Method for finding language
        /// </summary>
        /// <param name="language"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Language FindLanguage(Language language, string name) { language = Languages.Find(x => x.Name == name); return language; }
    }

    public class Language
    {
        //Propertyes
        public string Name => name;
        private string name;

        public List<Entry> EntryList { get; set; }


        /// <summary>
        /// Contrutor for adding languages
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="reference_"></param>
        public Language(string name_) { name = name_;  }

    }
}
