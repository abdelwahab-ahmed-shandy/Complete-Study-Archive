/// One To Many :

// شرح علاقة One To Many في قواعد البيانات
// علاقة One to Many (واحد إلى متعدد) هي نوع من العلاقات بين الجداول في قاعدة البيانات،
// حيث يكون لكل سجل في الجدول الأول ارتباط بعدة سجلات في الجدول الثاني، بينما يكون لكل سجل في الجدول الثاني ارتباط بسجل واحد فقط في الجدول الأول.

//=================================================================================================================================

// 📌 مثال عملي

// السيناريو:
// لنفترض أن لدينا قاعدة بيانات لمكتبة، ولدينا جدولين:
// جدول "المؤلفين" (Authors): يحتوي على معلومات عن المؤلفين.
// جدول "الكتب" (Books): يحتوي على الكتب التي كتبها المؤلفون.

// القاعدة:
// يمكن لمؤلف واحد كتابة عدة كتب.
// لكن كل كتاب مكتوب بواسطة مؤلف واحد فقط.
// هذا يعني أن العلاقة بين Authors و Books هي One to Many.

//=================================================================================================================================

// كيفية تمثيل العلاقة في قاعدة البيانات؟
// باستخدام المفاتيح الأساسية (Primary Key) والمفتاح الخارجي (Foreign Key)

// One :
public class Author
{
    public int AuthorID { get; set; }  // مفتاح أساسي
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>(); // علاقة One-To-Many
}

// Many :
public class Book
{
    public int BookID { get; set; }  // مفتاح أساسي
    public string Title { get; set; }
    public int AuthorID { get; set; }  // مفتاح خارجي يربط الكتاب بالمؤلف
    public Author Author { get; set; } // خصيصة التنقل
}

//=================================================================================================================================

// تكوين العلاقة باستخدام Fluent API:

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LibraryDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)  // كل كتاب له مؤلف واحد
            .WithMany(a => a.Books) // كل مؤلف لديه عدة كتب
            .HasForeignKey(b => b.AuthorID); // المفتاح الخارجي
    }
}

//=================================================================================================================================

// إدخال بيانات واختبار العلاقة:
using (var context = new LibraryContext())
{
    var author = new Author { Name = "نجيب محفوظ" };
    var book1 = new Book { Title = "الثلاثية", Author = author };
    var book2 = new Book { Title = "اللص والكلاب", Author = author };

    context.Authors.Add(author);
    context.Books.AddRange(book1, book2);
    context.SaveChanges();
}

//=================================================================================================================================

// جلب البيانات باستخدام Include:
using (var context = new LibraryContext())
{
    var authorsWithBooks = context.Authors.Include(a => a.Books).ToList();

    foreach (var author in authorsWithBooks)
    {
        Console.WriteLine($"✍️ المؤلف: {author.Name}");
        foreach (var book in author.Books)
        {
            Console.WriteLine($"   📖 {book.Title}");
        }
    }
}


