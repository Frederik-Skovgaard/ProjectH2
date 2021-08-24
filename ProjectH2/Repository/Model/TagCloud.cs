﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectH2.Repository.Controller;

namespace ProjectH2.Repository.Model
{
    
    class TagCloud
    {
        //Properties
        public Street street { get; set; }
        public List<Tag> TagsList => tag.TagList;

        private Tag tag;
    }

    public class Tag
    {
        //Tag List
        public List<Tag> TagList => tagList;
        private List<Tag> tagList;

        //Properties
        public string Name => name;
        public string Description => description;

        private string name;
        private string description;


        /// <summary>
        /// Constructor for making tags
        /// </summary>
        /// <param name="name_"></param>
        public Tag(string name_) { name = name_; }

        /// <summary>
        /// Method for find tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tag FindTag(Tag tag, string name) { tag = TagList.Find(x => x.Name == name); return tag; }
    }
}
