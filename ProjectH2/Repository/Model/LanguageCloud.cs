using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    class LanguageCloud
    {
        public Street Street { get; set; }
        public List<Language> Languages => language.Languages;

        private Language language;
    }

    public class Language
    {
        //List
        public List<Language> Languages => languages;
        private List<Language> languages;

        //Propertyes
        public string Name => name;
        public string Reference => reference;
        private string name;
        private string reference;


        //Add Language
        public Language(string name_, string reference_)
        {
            reference = reference_;
            name = name_;
        }

        public Language FindLanguage(Language language, string name)
        {
            language = languages.Find(x => x.Name == name);
            return language;
        }
    }
}
