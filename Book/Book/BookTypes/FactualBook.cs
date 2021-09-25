using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class FactualBook : Book
        {
        public int DifficultyLevel { get; set; }
        public string Subject { get; set; }
        FactualBook(string _title, string _author, int _pages,string _subject) : base(_title, _author, _pages)
        {
            Subject = _subject;
        }
        public FactualBook(string _title, string _author, int _pages, int _difficultyLevel, string _subject)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;
            DifficultyLevel = _difficultyLevel;
            Subject = _subject;
        }
        public void GetAll()
        {
        }

        public int GetDiffLev()
        {
            int i = DifficultyLevel;
            return i;
        }
        public string GetSubject()
        {
            string sub  = Subject;
            return sub;
        }
        public override string GetAll(List<Book> b)
        {
            string S = "";
            foreach (Book item in b)// Build string here Title : bookname
            {
                S = S + $"Title : {item.Title} \n";
                S = S + $"Author : {item.Author}\n";
                S = S + $"Number of Pages : {item.Pages}\n";
                int i= GetDiffLev();
                S = S + $"Number of Pages : {i}\n";
                string sub = GetSubject();
                S = S + $"Author : {sub}\n";

            }
            return S;
        }
    }
}
