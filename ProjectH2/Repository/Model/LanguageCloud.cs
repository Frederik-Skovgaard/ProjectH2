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
        public List<Language> Languages => languages;
        private List<Language> languages;
    }
}
