using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    
    public class TagCloud
    {
        //Properties
        public Street street { get; set; }
        public List<Tag> TagsList => tagList;
        private List<Tag> tagList = new List<Tag>();
        

        /// <summary>
        /// Method for find tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tag FindTag(Tag tag, string name) { tag = TagsList.Find(x => x.Name == name); return tag; }
    }

    public class Tag
    {
        //Properties
        public string Name => name;
        public string Description => description;

        private string name;
        private string description;


        /// <summary>
        /// Constructor for making tags
        /// </summary>
        /// <param name="name_"></param>
        public Tag(string name_, string description_) { name = name_; description = description_; SaveText(); }

        /// <summary>
        /// Method for adding tags to text file
        /// </summary>
        public void SaveText()
        {
            string path = @"C:\Users\fred56b8\Source\Repos\ProjectH2\ProjectH2\Repository\Model\Cloud.txt";
            using (TextWriter tw = new StreamWriter(path, true))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    tw.WriteLine($"{Name},{Description} (Tag)");
                }
                else
                {
                    tw.WriteLine($"{Name},{Description} (Tag)");
                }
            }
        }

    }
}
