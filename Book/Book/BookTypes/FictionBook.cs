using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class FictionBook : Book
    {
        public string Type { get; set; }
        public bool Anthology { get; set; }
        FictionBook(string _title, string _author, int _pages) : base(_title, _author, _pages)
        { }
        public FictionBook(string _title, string _author, int _pages, string _type, bool _anthology)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;
            Type = _type;
            Anthology = _anthology;
        }
        public override string GetAll(List<Book> b)
        {
            string s = "";
            return s;
        }
    }
}
