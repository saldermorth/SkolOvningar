using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book 
{
    public abstract class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
       public Book(string _title, string _author, int _pages)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;
        }
        public Book()
        {
            
        }
        
        public abstract string GetAll(List<Book> b);
        

        
        
    }
}
