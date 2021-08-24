using System;
using ProjectH2.Repository.Model;

namespace ProjectH2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Tag tag = new Tag("Name", "description");
            tag = new Tag("Wow", "Wow is a description");
        }
    }
}
