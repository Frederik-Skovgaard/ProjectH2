using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProjectH2.Model;

namespace ProjectH2.Repository
{

    public class CloudRepo
    {
        /// <summary>
        /// Read all tags, images, languages & files. Add them to there respected lists.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="image"></param>
        /// <param name="language"></param>
        /// <param name="file"></param>
        public async Task ReadFileToLists(Tag tag, Image image, Language language, Files file)
        {
            await tag.Reader();
            await image.Reader();
            await language.Reader();
            await file.Reader();
        }
    }
}
