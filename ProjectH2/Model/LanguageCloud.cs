﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProjectH2.Controller;

namespace ProjectH2.Model
{
    public class LanguageCloud
    {
        //Properties
        public Street Street { get; set; }
        public List<Language> Languages => languages.LanguageList;

        private Language languages;

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

        public List<Language> LanguageList => languageList;
        private List<Language> languageList = new List<Language>();


        /// <summary>
        /// Contrutor for adding languages
        /// </summary>
        /// <param name="name_"></param>
        /// <param name="reference_"></param>
        public Language(string name_) { name = name_;  }


        /// <summary>
        /// Read xml file and add to list
        /// </summary>
        public void Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = XDocument.Load(line);
            IEnumerable<XElement> langXML = xdoc.Root.Descendants("Tag");

            foreach (var xElement in langXML)
            {
                string langName = xElement.Element("Name").Value;

                languageList.Add(new Language(langName));

            }
        }

    }
}