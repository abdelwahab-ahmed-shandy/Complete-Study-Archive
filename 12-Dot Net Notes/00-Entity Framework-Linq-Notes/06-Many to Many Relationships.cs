/// Many To Many :

// شرح علاقة Many to Many في قواعد البيانات
// علاقة Many to Many (متعدد إلى متعدد) هي نوع من العلاقات بين الجداول في قاعدة البيانات،
// حيث يمكن لكل سجل في الجدول الأول أن يكون مرتبطًا بعدة سجلات في الجدول الثاني، والعكس صحيح.

//=================================================================================================================================

// 📌 مثال عملي

// السيناريو:
// لنفترض أن لدينا قاعدة بيانات لمكتبة، ولدينا جدولين:
// جدول "المؤلفين" (Authors): يحتوي على معلومات عن المؤلفين.
// جدول "الكتب" (Books): يحتوي على الكتب التي كتبها المؤلفون.

// القاعدة:
// يمكن لمؤلف واحد أن يكتب عدة كتب.
// ويمكن لكتاب واحد أن يكون له أكثر من مؤلف.
// هذا يعني أن العلاقة بين Authors و Books هي Many to Many.

//=================================================================================================================================

// كيفية تمثيل العلاقة في قاعدة البيانات؟
// نحتاج إلى جدول وسيط (Join Table) يسمى "AuthorBook" لتخزين العلاقة.

// الكيان الأول:
public class Author
{
    public int AuthorID { get; set; }  // مفتاح أساسي
    public string Name { get; set; }
    public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>(); // علاقة Many-To-Many
}

// الكيان الثاني:
public class Book
{
    public int BookID { get; set; }  // مفتاح أساسي
    public string Title { get; set; }
    public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>(); // علاقة Many-To-Many
}

// الجدول الوسيط:
public class AuthorBook
{
    public int AuthorID { get; set; }  // مفتاح خارجي
    public Author Author { get; set; }
    public int BookID { get; set; }  // مفتاح خارجي
    public Book Book { get; set; }
}

//=================================================================================================================================

// تكوين العلاقة باستخدام Fluent API:

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<AuthorBook> AuthorBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LibraryDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthorBook>()
            .HasKey(ab => new { ab.AuthorID, ab.BookID }); // تعيين مفتاح مركب

        modelBuilder.Entity<AuthorBook>()
            .HasOne(ab => ab.Author)
            .WithMany(a => a.AuthorBooks)
            .HasForeignKey(ab => ab.AuthorID);

        modelBuilder.Entity<AuthorBook>()
            .HasOne(ab => ab.Book)
            .WithMany(b => b.AuthorBooks)
            .HasForeignKey(ab => ab.BookID);
    }
}

//=================================================================================================================================

// إدخال بيانات واختبار العلاقة:
using (var context = new LibraryContext())
{
    var author1 = new Author { Name = "نجيب محفوظ" };
    var author2 = new Author { Name = "طه حسين" };

    var book1 = new Book { Title = "الثلاثية" };
    var book2 = new Book { Title = "الأيام" };

    var authorBook1 = new AuthorBook { Author = author1, Book = book1 };
    var authorBook2 = new AuthorBook { Author = author1, Book = book2 };
    var authorBook3 = new AuthorBook { Author = author2, Book = book2 };

    context.Authors.AddRange(author1, author2);
    context.Books.AddRange(book1, book2);
    context.AuthorBooks.AddRange(authorBook1, authorBook2, authorBook3);
    context.SaveChanges();
}

//=================================================================================================================================

// جلب البيانات باستخدام Include:
using (var context = new LibraryContext())
{
    var authorsWithBooks = context.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).ToList();

    foreach (var author in authorsWithBooks)
    {
        Console.WriteLine($"✍️ المؤلف: {author.Name}");
        foreach (var authorBook in author.AuthorBooks)
        {
            Console.WriteLine($"   📖 الكتاب: {authorBook.Book.Title}");
        }
    }
}