/*
Library Management
Required:

Create a class named Book.
The class has the following properties: title, author, firstReleaseDate ,availability .

Create a class named Library.
Link it to books and also make it add ReturnBook, AddBook and SearchBook.

Have it add, search and return books.
 */

namespace Library_Management
{
    class Book
    {
        public Book(string title, string author, int firstReleaseDate, bool availability = true)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("You Must Enter Title");
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("You Must Enter Author");
            if (firstReleaseDate <= 0)
                throw new ArgumentException("You Must Enter First Release Date");

            Title = title;
            Author = author;
            FirstReleaseDate = firstReleaseDate;
            Availability = availability;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public int FirstReleaseDate { get; private set; }
        public bool Availability { get; private set; }
    }
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Add Book ({book.Title}) , Author ({book.Author}) , FirstRelease ({book.FirstReleaseDate})");
        }
        public void SearchBook(string title)
        {
            bool Found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
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
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                    Found = true;
            }
            if (Found == false)
                Console.WriteLine($"Thanks for returning the {title}");
            else
                Console.WriteLine($"The {title} is already there, will you return it?");
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
}
