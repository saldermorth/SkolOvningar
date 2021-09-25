using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book 
{
    class KidBook : Book
    {
        public bool YoungAdult { get; set; }
        public bool PictureBook { get; set; }
        KidBook(string _title, string _author, int _pages) :base(_title, _author, _pages) 
        { 
        }
        public KidBook(string _title, string _author, int _pages, bool _youngAdult,  bool _picturebook)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;
            YoungAdult = _youngAdult;
            PictureBook = _picturebook;
        }
        public override string GetAll(List<Book> b)
        {
            string s = "";
            return s;
        }
    }
}
