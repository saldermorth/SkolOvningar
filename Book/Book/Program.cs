using System;
using System.Collections.Generic;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new KidBook("Hungry catepiller", "Timmy", 23, false, true));
            books.Add(new FictionBook("50 shades of Nej", "Some one", 666, "Tantsnusk", true));
            books.Add(new FactualBook("Code Complete", "Unckle Bob", 230, 2, "Programming"));
            books.Add(new KidBook("Harry Potter", "Dumbeldore", 356, true, false));
            books.Add(new KidBook("Hungry hippo", "Tommy", 23, false, true));

           

        }
        
        
    }
}
