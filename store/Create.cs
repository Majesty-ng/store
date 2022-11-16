using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class Create
    {
        public String Title;
        public String author;
        public int pages;
        public Create(String atitle, String aAuthor, int apages)
        {
            Title = atitle;
            author = aAuthor;
            pages = apages;
        }
    }
}
