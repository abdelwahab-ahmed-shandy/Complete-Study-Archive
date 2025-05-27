/*
 new : ستجد حل التاسك بطريقه اخري من  في ملف الاخر بالاسفل الفولدر 
 https://github.com/Abdelwahab-Shandy/Programming-Challenges-CSharp-Using-OOP
 Good evening, engineering,
 I don't know if I made the task as required or not,
 but this is what I was able to do and I implemented it in this way.
 I will try to do the task better,
 and put the new code in another file. Thank you. 
 */
using System;
using System.Runtime.CompilerServices;

namespace Task___3
{
    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"The Book Name is {book.title} And Author Name is {book.author} And History is {book.firstReleaseDate} ");
        }

        public void SearchBook(string title)
        {
            bool Found = false;
            for (int i = 0;i < books.Count ; i ++)
            {
                if (books[i].title == title)
                    Found = true;
            }
            if (Found == true)
                Console.WriteLine($"Yes the {title} it is available ");
            else
                Console.WriteLine($"No The {title} Not Found");
        }

        public void ReturnBook(string title)
        {
            bool Found = false;
            for (int i = 0;i < books.Count ; i ++)
            {
                if (books[i].title == title)
                    Found = true;
            }
            if (Found == false)
                Console.WriteLine($"Thanks for returning the {title}");
            else
                Console.WriteLine($"The {title} is already there, will you return it?");
        }

    }

        class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public bool availability { get; set; }
        public int firstReleaseDate { get; set; }

        public Book(string Title = "NoTitle", string Author = "NoAuthor",int FirstReleaseDate = 2000, bool Availability = true)
        {
            this.title = Title;
            this.author = Author;
            this.availability = Availability;
            this.firstReleaseDate = FirstReleaseDate;
        }
    }
   

        internal class Program
        {
            static void Main(string[] args)
            {
                Library library = new Library();

            // Adding books to the library
                library.AddBook(new Book("Running Linux" , "Matt Welsh" , 1995 ));
                library.AddBook(new Book("Linux Kernel Development", "Robert Love", 2003 ));
                library.AddBook(new Book("Linux Bible", "Christopher Negus", 2001 ));
            Console.WriteLine();
            // Searching and borrowing books
                library.SearchBook("Running Linux");
                library.SearchBook("Linux Bible");
                library.SearchBook("Linux");
            Console.WriteLine();
            // Returning books
                library.ReturnBook("Linux Kernel Development");
                library.ReturnBook("Gatsby");
                library.ReturnBook("Harry Potter");
            Console.WriteLine();
        }
    }
}

