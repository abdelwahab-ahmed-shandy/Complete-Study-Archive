/*
حل التاسك بطريقه مختلفه ، بعد تعلم بعض الاشياء من هنا :
https://www.youtube.com/playlist?list=PLsV97AQt78NT0H8J71qe7edwRpAirfqOI 

ايضا بعد تطبيق و مراجعه مفهوم ال
Encapsulation بشكل صحيح  مع القيم بطبيق بعض التطبيقات 
يمكنك النظر عليها من هنا :
https://github.com/Abdelwahab-Shandy/Programming-Challenges-CSharp-Using-OOP/tree/main
*/
using System;

namespace Library_Management
{
    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added Book: Title : {book.Title}, Author : {book.Author}, Release Year : {book.FirstReleaseDate}");
        }

        public void SearchBook(string title)
        {
            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                string status = book.Availability ? "available" : "currently borrowed";
                Console.WriteLine($"The book {title} is {status}");
            }
            else
            {
                Console.WriteLine($"The book {title} is not found in the library");
            }
        }

        public void ReturnBook(string title)
        {
            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                if (!book.Availability)
                {
                    book.Availability = true;
                    Console.WriteLine($"Thank you for returning the book {title}");
                }
                else
                {
                    Console.WriteLine($"The book {title} was not borrowed");
                }
            }
            else
            {
                Console.WriteLine($"The book {title} is not in our library collection");
            }
        }
    }

    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int FirstReleaseDate { get; private set; }
        public bool Availability { get; set; }

        public Book(string title, string author, int firstReleaseDate, bool availability = true)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be empty.");
            if (firstReleaseDate < 0 || firstReleaseDate > DateTime.Now.Year)
                throw new ArgumentException("Invalid release year.");

            Title = title;
            Author = author;
            FirstReleaseDate = firstReleaseDate;
            Availability = availability;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("Running Linux", "Matt Welsh", 1995));
            library.AddBook(new Book("Linux Kernel Development", "Robert Love", 2003));
            library.AddBook(new Book("Linux Bible", "Christopher Negus", 2001));
            Console.WriteLine();

            // Searching for books
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