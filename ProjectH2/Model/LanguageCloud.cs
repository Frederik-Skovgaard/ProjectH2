using System;
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

        //Language list with specific language for post
        public List<Language> Languages => languageList;
        private List<Language> languageList = new List<Language>();

        /// <summary>
        /// Method for adding to image list
        /// </summary>
        /// <param name="lang"></param>
        public void AddLanguage(Language lang)
        {
            languageList.Add(lang);
        }

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
        public async Task Reader()
        {
            string line = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Model\Cloud.xml";

            XDocument xdoc = await LoadAsync(line);

            //List of all tags
            IEnumerable<XElement> blog = xdoc.Root.Descendants("BlogPost");
            IEnumerable<XElement> fram = xdoc.Root.Descendants("FrameworkReview");
            IEnumerable<XElement> refe = xdoc.Root.Descendants("Reference");

            //Foreach language in Blog post
            foreach (XElement xElement in blog)
            {
                if (xElement.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = xElement.Descendants("EntryLanguage");
                    foreach (XElement xe in x)
                    {
                        string langName = xe.Element("EntryLanguageName").Value;

                        languageList.Add(new Language(langName));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }

            //Foreach language in Framework review
            foreach (XElement xElement in fram)
            {
                if (xElement.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = xElement.Descendants("EntryLanguage");
                    foreach (XElement xe in x)
                    {
                        string langName = xe.Element("EntryLanguageName").Value;

                        languageList.Add(new Language(langName));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }

            //Foreach language in Reference
            foreach (XElement xElement in refe)
            {
                if (xElement.Element("Active").Value != "False")
                {
                    IEnumerable<XElement> x = xElement.Descendants("EntryLanguage");
                    foreach (XElement xe in x)
                    {
                        string langName = xe.Element("EntryLanguageName").Value;

                        languageList.Add(new Language(langName));

                        xdoc.Save(line);
                    }
                }
                else
                {
                    xdoc.Save(line);
                }
            }
        }

        /// <summary>
        /// Asyncly read xml file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Task<XDocument> LoadAsync(String path)
        {
            return Task.Run(() =>
            {
                using (var stream = File.OpenText(path))
                {
                    return XDocument.Load(stream);
                }
            });
        }

        /// <summary>
        /// Method for adding to image list
        /// </summary>
        /// <param name="lang"></param>
        public void AddLanguage(Language lang)
        {
            languageList.Add(lang);
        }

    }
}
